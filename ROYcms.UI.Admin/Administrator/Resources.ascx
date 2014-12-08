<%@ Control Language="C#"  Inherits="ROYcms.UI.Admin.Administrator_Resources" %>
<!--页面加载等待-->
<script type="text/javascript">
window.onload=function(){ var a = document.getElementById("loading"); a.parentNode.removeChild(a);}
document.write('<div id="loading" style="background:#CC4444;color:#FFF;width:150px;padding-left:5px;position:absolute;line-height:30px">数据正在努力加载...</div>');
</script>
<!--页面加载等待-->
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/common.js"></script>
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/jquery-1.6.4.min.js"></script>
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/jquery-ui.js"></script>
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/formValidatorRegex.js"></script>
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/PopoBoxRegex.js"></script>
<script language="JavaScript"  type="text/javascript" src="/administrator/js/jquery.boxy.js"></script> 
<script language="JavaScript"  type="text/javascript" src="/administrator/js/jQuery.Hz2Py-min.js"></script> 
<script language="JavaScript"  type="text/javascript" src="/administrator/js/jquery.timers.js"></script> 


<script language="JavaScript" type="text/JavaScript" src="/administrator/js/TableList.js"></Script>
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/PopoBox.js"></script>
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/Admin.js"></script>
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/tabs.js"></script>


<link href="/Administrator/Bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css">
<link href="/Administrator/Bootstrap/css/bootstrap-responsive.css" rel="stylesheet" type="text/css">

<link href="/administrator/css/jquery-ui.css" rel="stylesheet" type="text/css" />
<link href="/administrator/css/common.css" rel="stylesheet" type="text/css" />
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css" />
<link href="/administrator/css/boxy.css" rel="stylesheet" type="text/css" />
<link href="/administrator/css/tabs.css" rel="stylesheet" type="text/css">



<script type="text/javascript" src="/Lib/html5.js"></script>

<script type="text/javascript" src="/Lib/bootstrap.min.js"></script>
<script type="text/javascript" src="/administrator/bootstrap/bootstrap.js"></script>


<script type="text/javascript">
	$(function(){
		$("a[rel=facebox]").boxy();
	});
</script>