using System;
using System.Collections.Generic;
using System.Text;

namespace ROYcms.Templet
{
    public class ResponseForm
    {
        /// <summary>
        /// 输出智能表单   返回一个字段的HTML的描述 方法
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public static string FormPut(ROYcms.Sys.Model.ROYcms_Field Model)
        {
            return FormPut("","",Model.Name, Model.Lable, Model.Len.ToString(), Model.FieldType.ToString(), Model.IsNull.ToString(), Model.DefaultVal, Model.Display.ToString(), Model.InputType.ToString(), Model.InputLen.ToString());
        }

        /// <summary>
        ///  输出智能表单 返回一个字段的HTML的描述 方法
        /// </summary>
        /// <param name="Name">字段名称 字段名称</param>
        /// <param name="Lable">字段的Lable 字段的Lable</param>
        /// <param name="Len">字段的长度 字段的长度</param>
        /// <param name="FieldType">字段的类型 字段的类型</param>
        /// <param name="IsNull">是否为空 是否为空</param>
        /// <param name="DefaultVal">默认值 默认值</param>
        /// <param name="Display">显示可见状态 显示可见状态</param>
        /// <param name="InputType"> input输入框的类型</param>
        /// <param name="InputLen">Input的显示长度</param>
        /// <returns>返回一个字段的HTML的描述</returns>
        public static string FormPut(string Id,string Class, string Name, string Lable, string Len, string FieldType, string IsNull, string DefaultVal, string Display, string InputType, string InputLen)
        {
            ROYcms.Sys.BLL.ROYcms_Custom CustomBLL = new ROYcms.Sys.BLL.ROYcms_Custom();
            ROYcms.Sys.BLL.ROYcms_news ROYcms_newsBLL = new ROYcms.Sys.BLL.ROYcms_news();
            string FieldVal = null;
            if (Id != null && Class != null) //如果是编辑
            {
                if (!Name.Contains("_R"))
                {
                    FieldVal = CustomBLL.GetVal(Convert.ToInt32(Id), Convert.ToInt32(Class), Name);
                }
                else
                {
                    if (Name == "_RTitle")
                    {
                        FieldVal = ROYcms_newsBLL.GetField(Convert.ToInt32(Id), "title");
                    }
                    else if (Name == "_RContent")
                    {
                        FieldVal = ROYcms_newsBLL.GetField(Convert.ToInt32(Id), "contents");
                    }
                }
            }
            DefaultVal = FieldVal;


            string Html = null;
            string input = "<input id='ROYcms_[Name]' name='ROYcms_[Name]' type='[InputType]' value='[DefaultVal]' maxlength='[Len]' style='width:[InputLen]px;' class='txtInput'  />";
            string textarea = "<textarea id='ROYcms_[Name]' name='ROYcms_[Name]'>[DefaultVal]</textarea>";
            string Editor = @"<script>
                            var editor;
                            KindEditor.ready(function(K) {
                                    editor = K.create('#ROYcms_[Name]',{				
                                    cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                    uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=News,Content',
				                    fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=News,Content',
                                    autoHeightMode : true,
				                    allowFileManager : true 
				                });
                            });
                          </script>
                                   <textarea class='REditor' id='ROYcms_[Name]' name='ROYcms_[Name]' style='width:100%;height:360px;'>[DefaultVal]</textarea>";
            string EditorBasic = @"<script>
                            var Editor[Name];
                            KindEditor.ready(function(K) {
                                    Editor[Name] = K.create('#ROYcms_[Name]', {
					                resizeType : 1,
					                allowPreviewEmoticons : false,
					                allowImageUpload : false,
					                items : [
						                'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold', 'italic', 'underline',
						                'removeformat', '|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
						                'insertunorderedlist', '|', 'emoticons', 'image', 'link']
				                });
                            });
                          </script>
                                   <textarea class='REditor' id='ROYcms_[Name]' name='ROYcms_[Name]' style='width:[InputLen]px;height:200px;'>[DefaultVal]</textarea>";

            string UFile = @"
		                        <script>
			                        KindEditor.ready(function(K) {
				                        var editor = K.editor({				
                                                    cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                                    uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=News,Content',
				                                    fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=News,Content',
				                                    allowFileManager : true 
				                });

				                        K('#fileDialog[Name]').click(function() {
					                        editor.loadPlugin('insertfile', function() {
						                        editor.plugin.fileDialog({
							                        fileUrl : K('#ROYcms_[Name]').val(),
							                        clickFn : function(url, title) {
								                        K('#ROYcms_[Name]').val(url);
								                        editor.hideDialog();
							                        }
						                        });
					                        });
				                        });
			                        });
		                        </script>
                                 
                               <input type='text' id='ROYcms_[Name]' name='ROYcms_[Name]' value='[DefaultVal]' class='txtInput'  /> <input type='button' id='fileDialog[Name]' value='选择文件' />

                 ";

            string UImg = @"
		                        <script>
			                       			KindEditor.ready(function(K) {
				                            var editor = K.editor({
					                              cssPath : '/Administrator/Editor/plugins/code/prettify.css',
				                                    uploadJson : '/Administrator/Editor/C/upload_json.ashx?root=News,Content',
				                                    fileManagerJson : '/Administrator/Editor/C/file_manager_json.ashx?root=News,Content',
				                                    allowFileManager : true 
				                            });
				                            K('#imageDialog[Name]').click(function() {
					                            editor.loadPlugin('image', function() {
						                            editor.plugin.imageDialog({
							                            imageUrl : K('#ROYcms_[Name]').val(),
							                            clickFn : function(url, title, width, height, border, align) {
								                            K('#ROYcms_[Name]').val(url);
								                            editor.hideDialog();
							                            }
						                            });
					                            });
				                            });
                                        });
		                        </script>
                                 
                               <input type='text' id='ROYcms_[Name]' name='ROYcms_[Name]' value='[DefaultVal]' class='txtInput' /> <input type='button' id='imageDialog[Name]' value='选择图片' />

                 ";

            if (InputType == "1") //文本框
            {
                Html = input;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());
            }
            else if (InputType == "2") //多行输入
            {
                Html = textarea;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());
            }
            else if (InputType == "3") //单选按钮
            {
                Html = input;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());
            }
            else if (InputType == "4") //复选框
            {
                Html = input;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());
            }
            else if (InputType == "5") //下拉列表
            {
                Html = input;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());
            }
            else if (InputType == "6" && Name.Contains("_RContent"))  //编辑器 复杂
            {
                Html = Editor;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());

            }
            else if (InputType == "6" && !Name.Contains("_RContent"))  //编辑器  简单
            {
                Html = EditorBasic;
                Html = Html.Replace("[Name]", Name.Trim());
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());

            }
            else if (InputType == "7") //上传图片
            {
                Html = UImg;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());
            }
            else if (InputType == "8") //上传文件
            {
                Html = UFile;
                Html = Html.Replace("[Name]", Name);
                Html = Html.Replace("[InputType]", "text");
                Html = Html.Replace("[InputLen]", InputLen);
                Html = Html.Replace("[DefaultVal]", DefaultVal);
                Html = Html.Replace("[Len]", (Convert.ToInt32(Len) / 2).ToString());
            }
            return Html;
        }
    }
}
