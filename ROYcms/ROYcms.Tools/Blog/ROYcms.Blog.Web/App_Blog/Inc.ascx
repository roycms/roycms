<!--页面加载等待-->
<script type="text/javascript">
window.onload=function(){
  var a = document.getElementById("loading");
  a.parentNode.removeChild(a);
}
document.write('<div id="loading" style="font-size:12px;background:#CC4444;color:#FFF;width:80px; padding-left:5px;position:absolute;line-height:22px">正在读取...</div>');
</script>
<!--预先导入样式和JS-->
<script src="/administrator/webui/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="/administrator/webui/SpryAssets/SpryValidationTextarea.js" type="text/javascript"></script>
<link href="/administrator/webui/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css" />
<link href="/administrator/webui/SpryAssets/SpryValidationTextarea.css" rel="stylesheet" type="text/css" />
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.2.6/jquery.min.js" type="text/javascript"></script>