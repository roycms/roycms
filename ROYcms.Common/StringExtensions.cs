//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace ROYcms.Common
//{
//    public static class StringExtensions
//    {
//        private static Regex HTMLSpanRegex = new Regex(
//            @"(?imx)   
//         (?<Start><(?<Tag>\w+)(?>[^>]*)>)   
//          (?>                                                                    #分组构造，用来限定量词“*”修饰范围   
//           (?<InnerHTML>(?:[^<>]|(?:<\w+[^/>]*/>))+)                           #非括弧的其它任意字符   
//           |(?<TagStart><\w+(?>[^>]*)>)       (?<Open>)                     #命名捕获组，遇到开括弧Open计数加1   
//           |(?<TagEnd></\w+>)                   (?<-Open>)                    #狭义平衡组，遇到闭括弧Open计数减1                                                                  
//          )*                                                                    #以上子串出现0次或任意多次   
//          (?(Open)(?!))                                                         #判断是否还有'OPEN'，有则说明不配对，什么都不匹配   
//         (?<End></\k<Tag>>)", RegexOptions.Compiled);

//        private static Regex NullTagFilter = new Regex(
//            @"(?imx)   
//         <(?<Tag>\w+)(?>[^>/]*)>   
//          (?>    
//        <\w+(?>[^>/]*)> (?<Open>)                                         #命名捕获组，遇到开括弧Open计数加1   
//           |</\w+>            (?<-Open>)                                        #狭义平衡组，遇到闭括弧Open计数减1                                                                  
//          )*                                                                    #以上子串出现0次或任意多次   
//          (?(Open)(?!))                                                         #判断是否还有'OPEN'，有则说明不配对，什么都不匹配   
//         </\k<Tag>>", RegexOptions.Compiled);

//        private static string FixedString =
//            @"(?imx)^   
//         (?>(?<WD_Count>[\u0100-\uffff])   
//         |(?<NR_Count>(?>(?:&\w+;)|(?:<\w+[^/>]*/>)|[\u0000-\u00ff])){{1,2}}){{0,{0}}}";

//        private static IDictionary<int, Regex> FixedStringRegexs = new Dictionary<int, Regex>();

//        public static string Cut( string str, int length, string prefix)
//        {
//            //入栈动作   
//            const int PU = 0x01;
//            //出栈动作   
//            const int PO = 0x02;

//            //STEP0 预处理   
//            str = Regex.Replace(str, @"\s+", " ");

//            //STEP1 准备动作表   
//            //Index Action Length   
//            IList<int[]> acTable = new List<int[]>();
//            var ms = HTMLSpanRegex.Matches(str).Cast<Match>().ToArray();
//            //首部非Tag内字符处理   
//            if (ms.Length <= 0)
//                acTable.Add(new int[] { 0, 0, str.Length });
//            else
//                acTable.Add(new int[] { 0, 0, ms[0].Index });

//            for (int i = 0; i < ms.Length; i++)
//            {
//                //Tag主起始标签处理   
//                acTable.Add(new int[] { ms[i].Groups["Start"].Index, PU, ms[i].Groups["Start"].Length });

//                //Tag内含纯文字处理   
//                foreach (var cap in ms[i].Groups["InnerHTML"].Captures.Cast<Capture>())
//                    acTable.Add(new int[] { cap.Index, 0, cap.Length });

//                //Tag内含起始标签处理   
//                foreach (var cap in ms[i].Groups["TagStart"].Captures.Cast<Capture>())
//                    acTable.Add(new int[] { cap.Index, PU, cap.Length });

//                //Tag内含截止标签处理   
//                foreach (var cap in ms[i].Groups["TagEnd"].Captures.Cast<Capture>())
//                    acTable.Add(new int[] { cap.Index, PO, cap.Length });

//                //Tag主截止标签处理   
//                acTable.Add(new int[] { ms[i].Groups["End"].Index, PO, ms[i].Groups["End"].Length });

//                //Tag后非内含文字处理   
//                if (i < ms.Length - 1)
//                {
//                    var mStart = ms[i].Index + ms[i].Length;
//                    var mLength = ms[i + 1].Index - mStart;
//                    acTable.Add(new int[] { mStart, 0, mLength });
//                }
//            }

//            //末尾非内含文字处理   
//            if (ms.Length > 0)
//            {
//                var mStart = ms[ms.Length - 1].Index + ms[ms.Length - 1].Length;
//                var mLength = str.Length - mStart;
//                acTable.Add(new int[] { mStart, 0, mLength });
//            }

//            //STEP2 过滤/排序及分段截取   
//            var sb = new StringBuilder();
//            //简化的栈，仅作为平衡标记   
//            var stack = 0;
//            var vl = length - 0.5f;
//            foreach (var ac in from itm in acTable
//                               where itm[2] > 0
//                               orderby itm[0]
//                               select itm)
//            {
//                if (vl < 0.1f && stack == 0)
//                    break;

//                //入栈   
//                if ((ac[1] & PU) > 0 && (vl > 0.4f || stack > 0))
//                {
//                    sb.Append(str, ac[0], ac[2]);
//                    stack++;
//                }
//                //出栈   
//                else if ((ac[1] & PO) > 0 && stack > 0)
//                {
//                    sb.Append(str, ac[0], ac[2]);
//                    stack--;
//                }
//                //内裁减   
//                else if (vl > 0.4f)
//                {
//                    var tmp = str.Substring(ac[0], ac[2]);
//                    var l = (int)Math.Ceiling(vl);
//                    if (tmp.Length < l)
//                        l = tmp.Length;

//                    if (!FixedStringRegexs.ContainsKey(l))
//                        FixedStringRegexs[l] = new Regex(string.Format(FixedString, l * 2), RegexOptions.Compiled);

//                    //标记单元字符   
//                    var m = FixedStringRegexs[l].Match(tmp);

//                    if (tmp.Length < l)
//                    {
//                        //子串较短时，可避免下面的循环   
//                        sb.Append(m.Value);
//                        vl -= m.Groups["WD_Count"].Captures.Count + m.Groups["NR_Count"].Captures.Count / 2.0f;
//                    }
//                    else
//                    {
//                        //窄字符   
//                        var nr = m.Groups["NR_Count"].Captures.Cast<Capture>();
//                        //宽字符   
//                        var wd = m.Groups["WD_Count"].Captures.Cast<Capture>();

//                        //单元字符合并/排序/插入   
//                        foreach (var cap in nr.Concat(wd).OrderBy(cap => cap.Index))
//                        {
//                            if (vl < 0.1f)
//                                break;
//                            sb.Append(tmp, cap.Index, cap.Length);

//                            if (nr.Contains(cap))
//                                vl -= 0.5f;
//                            else
//                                vl -= 1;
//                        }
//                    }
//                }
//            }

//            //STEP3 空标签过滤   
//            var ret = sb.ToString();
//            ret = NullTagFilter.Replace(ret, "");

//            //STEP4 添加后缀   
//            if (vl < -0.1f)
//                return ret + prefix;
//            else if (vl > 0.1f)
//                return ret;
//            else
//                return ret + " " + prefix;
//        }

//        public static string Cut(string str, int length)
//        {
//            return str.Cut(length, "...");
//        }
//    }
//}  
