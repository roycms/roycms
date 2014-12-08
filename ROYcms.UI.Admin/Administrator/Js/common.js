/*===========================Roy==========================================*/

//验证邮件合法的方法
function Email(e){
	 var reg = /^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/; //验证邮箱的正则表达式
			if(!reg.test(e))
				{
					//alert("邮箱格式不对");
					return false;
				}
				else{return true;}
	}

　　//得到焦点时触发事件
function onFocusFun(element, elementValue,styles) {
　　  if (element.value == elementValue) {
　　   element.value = "";
　　   element.style.color = styles;
　　  }
　　}

　　//离开输入框时触发事件
function onblurFun(element, elementValue,styles) {
　　  if (element.value == '') {
　　   element.style.color = styles;//"#72a5c0"
　　   element.value = elementValue;
　　  }
　　}
//去除换行
function clearBr(key) 
{ 
    key = key.replace(/<\/?.+?>/g,""); 
    key = key.replace(/[\r\n]/g, ""); 
    return key; 
} 
//url编码
function urlEncode(str)
{
    var ret = "";
    var strSpecial = "!\"#$%&’()*+,/:;<=>?[]^`{|}~%";
    var tt = "";
    for(var i = 0; i < str.length; i++)
    {
        var chr = str.charAt(i);
        var c = str2asc(chr);
        tt += chr + ":" + c + "n";
        if (parseInt("0x" + c) > 0x7f)
        {
            ret += "%" + c.slice(0,2) + "%" + c.slice(-2);
        }
        else
        {
            if (chr == " ")
                ret += "+";
            else if (strSpecial.indexOf(chr) != -1)
                ret += "%" + c.toString(16);
            else
                ret += chr;
        }
    }
   
    return ret;
}
 //url解码
function urlDecode(str)
{
    var ret = "";
    for (var i = 0; i < str.length; i++)
    {
        var chr = str.charAt(i);
        if (chr == "+")
        {
            ret += " ";
        }
        else if (chr == "%")
        {
            var asc = str.substring(i+1, i+3);
            if (parseInt("0x"+asc) > 0x7f)
            {
                ret += asc2str(parseInt("0x" + asc+str.substring(i+4, i+6)));
                i += 5;
            }
            else
            {
                ret += asc2str(parseInt("0x"+asc));
                i += 2;
            }
        }
        else
        {
            ret += chr;
        }
    }
   
    return ret;
}
