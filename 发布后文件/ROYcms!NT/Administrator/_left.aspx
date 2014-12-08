<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin.Administrator_admin_left" Codebehind="_left.aspx.cs" %>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title></title>
<link href="/administrator/css/style.css" rel="stylesheet" type="text/css">
<script language="JavaScript" type="text/JavaScript" src="/administrator/js/jquery-1.6.4.min.js"></script>
<script language="JavaScript"  src="/administrator/js/alt.js"></script>
<style type="text/css">
<!--
body, td, th {
	font-size: 14px;
	overflow-x:hidden;
	overflow-y:auto;
}
-->
</style>
</head>
<script type="text/javascript"> 
function Tab(id)
    {	
     if(id==1){$("#tab1").fadeIn("slow");$("#tab2").fadeOut("slow");$("#tab3").fadeOut("slow");$("#tab4").fadeOut("slow"); }
     else if(id==2){$("#tab2").fadeIn("slow");$("#tab1").fadeOut("slow");$("#tab3").fadeOut("slow");$("#tab4").fadeOut("slow");}
     else if(id==3){$("#tab3").fadeIn("slow");$("#tab1").fadeOut("slow");$("#tab2").fadeOut("slow");$("#tab4").fadeOut("slow");}
     else{$("#tab4").fadeIn("slow");$("#tab1").fadeOut("slow");$("#tab2").fadeOut("slow");$("#tab3").fadeOut("slow");}
    }
</script>
<body style="overflow-x:hidden;overflow-y:auto">
<form id="form1" runat="server">
  <table width="230" height="100%" border="0" cellpadding="0" cellspacing="0">
    <tr>
      <td align="center" valign="top" style="background-image: url(images/admin-leftbg.gif);background-repeat: repeat-y;">
      <div style="width:210px;overflow:auto;height:100%; padding:0px; margin:0px;">
          <div id="Tab" class="pz"> 
          <span><a class="pz_1" href="javascript:" onClick="Tab(1)">管理</a></span> 
          <span><a class="pz_2" href="javascript:" onClick="Tab(2)">配置</a></span> 
          <span><a class="pz_3" href="javascript:" onClick="Tab(3)">插件</a></span> 
          <span><a class="pz_4" href="javascript:" onClick="Tab(4)">会员</a></span> 
          </div>
          <!--选项卡效果-->
          <div id="tab1"> 
               <!--admin开始-->
               <asp:Repeater ID="Repeater_Objet" runat="server">
                <HeaderTemplate>
                <table width="160" border="0" cellpadding="0" cellspacing="0">
                <tr>
                <td>
                </HeaderTemplate>
                <ItemTemplate>
                    <table width="100%" height="25" border="0" cellpadding="0" cellspacing="5" style="margin-top:10px;margin-bottom:10px;background-color: #FFFFFF;border: 1px solid #DDEDF6;">
                    <tr>
                    <td>
                    <img src="<%#Eval("logo") %>" align="absmiddle" alt="<%#Eval("zhaiyao") %>" /> <font color="#FF3300" style="margin-left:5px;"> <b title="<%#Eval("zhaiyao") %>"><%#Eval("Title") %></b> </font>
                    </td>
                    </tr>
                    </table>
                    <table width="100%" border="0" cellspacing="0" cellpadding="4">
                    <tr>
                     <td>
                     <img src="images/plus-.gif" align="absmiddle" alt="ROYcms!NT" /> <a href="class/index.aspx?Classkind=<%#Eval("ClassKind") %>" title="<%#Eval("zhaiyao") %>" target="mainFrame"><%#Eval("title") %></a>
                     </td>
                    </tr>
                    </table>
                </ItemTemplate>
                <FooterTemplate>
                    <%#Repeater_Objet.Items.Count == 0 ? "<a href='/administrator/go/Insert.aspx'  target='mainFrame' style=\"padding-top:5px;\">暂无模块点击添加模块儿</a>" : ""%>  
                    </td>
                    </tr>
                </table>
                </FooterTemplate>
        </asp:Repeater>
          </div>
          <div id="tab2" style="display:none;"><asp:Xml ID="Xml1" runat="server"></asp:Xml></div>
          <div id="tab3" style="display:none;"><asp:Xml ID="Xml2" runat="server"></asp:Xml></div>
          <div id="tab4" style="display:none;"><asp:Xml ID="Xml3" runat="server"></asp:Xml></div>
        </div>
        </td>
    </tr>
  </table>
  <Script>
      function scr() {
          document.getElementById("Tab").style.top = (document.documentElement.scrollTop) + "px";
          document.getElementById("Tab").style.left = (document.documentElement.scrollLeft) + "px";
      }
      function scall() {
          scr();
      }
      window.onscroll = scall;
</Script>
</form>
</body>
</html>