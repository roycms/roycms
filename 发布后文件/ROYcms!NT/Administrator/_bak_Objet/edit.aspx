<%@ Page Language="C#" AutoEventWireup="True" Inherits="ROYcms.UI.Admin.Administrator_Objet_edit" ValidateRequest="false" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>            
<!DOCTYPE HTML>
<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<script src="/administrator/js/SpryAssets/SpryTabbedPanels.js" type="text/javascript"></script>
<link href="/administrator/css/SpryAssets/SpryTabbedPanels.css" rel="stylesheet" type="text/css">
</head>
<body>
<form runat=server>
<Resources:Resources ID="Resources1" runat="server" />
  <table width="100%" border="0" cellspacing="0" cellpadding="2">
    <tr>
      <td height="99">
      
 
        <table width="100%" border="0" class="tiao_top">
      <tr>
        <td width="77%" nowrap><div class="tiao_con">
        <a href="/administrator/objet/xclass.aspx?Classkind=<% =this.ClassKind %>"><img align="absmiddle" src="/administrator/images/nv6.png" />添加信息</a> 
        <a href="/administrator/objet/admin.aspx?Classkind=<% =this.ClassKind %>"><img align="absmiddle" src="/administrator/images/nv8.png" />管理信息</a> 
        <a href='/administrator/class/index.aspx?ClassKind=<% =ClassKind %>'><img align="absmiddle" src="/administrator/images/nv9.png" />分类管理</a> 

        
        </div></td>
        <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
      </tr>
    </table>
    
      <div id="TabbedPanels1" class="TabbedPanels">
                  <ul class="TabbedPanelsTabGroup">
                    <li class="TabbedPanelsTab" tabindex="0">基本信息录入
                      <a class="submodal-600-450" href='Attribute.aspx?GUID=<%=this.GUID%>&ClassKind=<%=this.ClassKind%>'><img src="/administrator/images/up.gif" alt="" name="" width="16" height="16" border="0"></a>
                    </li>
                    <li class="TabbedPanelsTab" tabindex="0">扩展属性录入
                      <a class="submodal-600-450" href='Attribute.aspx?GUID=<%=this.GUID%>&ClassKind=<%=this.ClassKind%>'><img src="/administrator/images/up.gif" alt="" name="" width="16" height="16" border="0"></a>
                    </li>
                    <li class="TabbedPanelsTab" tabindex="0"><a class="submodal-500-420" href='Appendix.aspx?GUID=<%=this.GUID%>&ClassKind=<%=this.ClassKind%>'>附件信息录入</a>
                      <a class="submodal-400-320" href='Appendix.aspx?GUID=<%=this.GUID%>&ClassKind=<%=this.ClassKind%>'><img src="/administrator/images/up.gif" alt="" name="" width="16" height="16" border="0"></a>
                    </li>
                  </ul>
                  <div class="TabbedPanelsContentGroup">
                    <div class="TabbedPanelsContent">
                          <table width="99%" border="0" cellpadding="3" cellspacing="0" style="margin-top:6px">
        <tr>
          <td height="280" valign="top"><table width="100%" height="270" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td height="270">
                <table width="99%" border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="#DFDFDF" id="add_table">
                  <tr>
                    <td colspan="3" align="left" nowrap bgcolor="#DDE9FF">切换模式
                           <label><input type="radio" name="_ms" value="2" id="_ms_2" checked>自定义模式</label>
                           <label><input name="_ms" type="radio" id="_ms_0" value="1" >详细模式</label>
                           <label><input type="radio" name="_ms" value="2" id="_ms_1">简单模式</label>
                    </td>
                    </tr>
                    <tr>
                    <td align="right" bgcolor="#F4FBFF">选择分类： &nbsp;</td>
                    <td nowrap bgcolor="#F4FBFF"><asp:DropDownList AutoPostBack="True" CssClass="TabbedPanelsTab" ID="DdlMenu" runat="server" Width="320" ></asp:DropDownList></td>
                    <td width="91%" align="center" nowrap bgcolor="#F4FBFF">&nbsp;</td>
                    </tr>
                  <tr>
                  
                    <td width="7%" align="right" nowrap bgcolor="#F4FBFF">信息标题： &nbsp;</td>
                    <td width="91%" nowrap bgcolor="#F4FBFF"><asp:TextBox ID="txttitle" runat="server" Width="400px" CssClass="input"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                          ControlToValidate="txttitle" ErrorMessage="请填写标题" Display="Dynamic"></asp:RequiredFieldValidator>
                      <asp:CheckBox Checked="false" ID="ding" runat="server" Text="置顶" title="新闻置顶" />                      
                      <asp:CheckBox Checked="false" ID="tuijian" runat="server" Text="推荐" title="新闻推荐" />                      
                      <asp:CheckBox Checked="true" ID="switchs" runat="server" Text="发布" title="新闻发布" /></td>
                    <td width="91%" align="center" nowrap bgcolor="#F4FBFF">&nbsp;</td>
                  </tr>
                  <tr>
                    <td align="right" nowrap bgcolor="#F4FBFF">属性： &nbsp;</td>
                    <td valign="top" nowrap bgcolor="#F4FBFF">

<table width="500" border="0" cellpadding="3" cellspacing="0">
  <tr>
    <td nowrap>出处:
      <asp:TextBox ID="txtinfor" runat="server" CssClass="input" Width="50px" Height="20px">原创</asp:TextBox></td>
    <td nowrap>作者:
      <asp:TextBox ID="txtauthor" runat="server" CssClass="input" Width="50px" Height="20px"></asp:TextBox></td>
   
    <td nowrap>阅读次数:
      <asp:TextBox ID="txthits" runat="server" CssClass="input" Width="40px" Height="20px" Text="0"></asp:TextBox></td>
    <td nowrap>顶次数:
      <asp:TextBox ID="txtdig" runat="server" CssClass="input" Width="40px" Height="20px" Text="0"></asp:TextBox></td>
    <td rowspan="2" nowrap>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;(均为可选属性) </td>
  </tr>
  <tr>
    <td nowrap> 权重:
      <select name="orders" class="drw_list" id="orders" style="height:18px" runat="server">
        <option value="">选择</option>
        <option value="1">001</option>
        <option value="2">002</option>
        <option value="3">003</option>
        <option value="4">004</option>
        <option value="5">005</option>
        <option value="6">006</option>
        <option value="7">007</option>
        <option value="8">008</option>
        <option value="9">009</option>
        <option value="10">010</option>
      </select></td>
    <td nowrap>样式:
      <select name="styles" class="drw_list" id="styles" style="height:18px" runat="server">
        <option value="">选择</option>
        <option value="1">字+1</option>
        <option value="2">字+2</option>
        <option value="3">字+3</option>
        <option value="4">字+4</option>
        <option value="5">字+5</option>
      </select></td>
    <td nowrap>颜色:
      <select name="colors" class="drw_list" id="colors" style="height:18px" runat="server">
        <option value="">选择</option>
        <option value="red">红色</option>
        <option value="blue">蓝色</option>
        <option value="green">绿色</option>
        <option value="black">黑色</option>
      </select></td>
    <td nowrap>&nbsp;</td>
    <td nowrap>&nbsp;</td>
    </tr>
</table></td>
                    <td align="center" valign="middle" nowrap bgcolor="#F4FBFF" width="35">
                    <a href="#" title="点击关闭该项" id="_c1"><font color="#C2CCCC">X</font></a>
                    </td>
                    </tr>
                  <tr>
                    <td align="right" nowrap bgcolor="#F4FBFF">关键字： &nbsp;</td>
                    <td nowrap bgcolor="#F4FBFF"><asp:TextBox ID="keyword" runat="server" Width="400px" CssClass="input"></asp:TextBox>
                      <span class="_help">                      [每个关键字请用英文的逗号隔开例“,”] </span>(可选)</td>
                    <td align="center" nowrap bgcolor="#F4FBFF"><a href="#" title="点击关闭该项" id="_c2"><font color="#C2CCCC">X</font></a></td>
                    </tr>
                  <tr>
                    <td align="right" nowrap bgcolor="#F4FBFF">摘要： &nbsp;</td>
                    <td nowrap bgcolor="#F4FBFF"><asp:TextBox ID="txtzhaiyao" runat="server" Width="400px" 
                            CssClass="input" Height="45px" TextMode="MultiLine"></asp:TextBox>
                        (可选)</td>
                    <td align="center" nowrap bgcolor="#F4FBFF"><a href="#" title="点击关闭该项"  id="_c3"><font color="#C2CCCC">X</font></a>&nbsp;</td>
                  </tr>
                  <tr>
                            <td align="right" nowrap bgcolor="#F4FBFF">形象图片： &nbsp;</td>
                    <td nowrap bgcolor="#F4FBFF">
                      <asp:TextBox ID="txtpic" CssClass="input" runat="server" Width="200px" ></asp:TextBox>

                    
 <%if (this.txtpic.Text == "")
  { %>
  <img id=pic_img src='/administrator/images/no_pic.gif' alt='未上传图片' width='16' height='16' border='0'>
  <%}
  else
  { %>
  
   <img src="/administrator/images/cms-ico6.gif" alt="删除上传的文件 " onClick="return window.confirm('确定要删除上传的文件吗?');" name="del_pic" width="8" height="7" border="0" id="del_pic">
                          
  
  <a href='<% = this.txtauthor.Text %>' target='_blank'><img id=pic_img src='/administrator/images/pic.gif' alt='查看上传的图片' width='16' height='16' border='0'></a>
  
  
  <%} %>
                    
                    
                                                   <span class="bt">
       &nbsp; 
       <a onClick="showPopWin('/administrator/FileManager/Appendix_Default.aspx?path=default&id=1', 660, 400, GET_IMG_pic);">
       <img src="http://www.roycms.cn/administrator/images/eye.png" border="0" /> 浏览服务器...&nbsp;</a> 
       </span>
       
        <script language="javascript" type="text/javascript">
       function GET_IMG_pic(returnVal){document.getElementById("txtpic").value=returnVal; }
       </script>
                         
                         
                        
                           
                        </td>
                    <td align="center" nowrap bgcolor="#F4FBFF"><a href="#" title="点击关闭该项"  id="_c4"><font color="#C2CCCC">X</font></a></td>
                    </tr>
                  <tr>
                    <td align="right" nowrap bgcolor="#F4FBFF">链接： &nbsp;</td>
                    <td nowrap bgcolor="#F4FBFF"><asp:TextBox ID="txturl" runat="server"  CssClass="input" Width="320px"></asp:TextBox>
                        (可选)</td>
                    <td align="center" nowrap bgcolor="#F4FBFF"><a href="#" title="点击关闭该项"  id="_c5"><font color="#C2CCCC">X</font></a></td>
                    </tr>
                  <tr>
                    <td align="right" nowrap bgcolor="#F4FBFF">跳转URL： &nbsp;</td>
                    <td nowrap bgcolor="#F4FBFF"><asp:TextBox ID="jumpurl" runat="server"   CssClass="input" Width="320px"></asp:TextBox>
                        (可选)
<asp:CheckBox Checked="false" ID="jumpurl_on_of" runat="server" Text="启用跳转" title="新闻跳转" /></td>
                    <td align="center" nowrap bgcolor="#F4FBFF"><a href="#" title="点击关闭该项"  id="_c6"><font color="#C2CCCC">X</font></a></td>
                    </tr>
                  <tr>
                    <td align="right" nowrap bgcolor="#F4FBFF">标签TAG： &nbsp;</td>
                    <td nowrap bgcolor="#F4FBFF"><asp:TextBox ID="txttag" runat="server"   CssClass="input" Width="320px"></asp:TextBox>
                      <span class="_help">            
                      
                            <a class="submodal-300-260" href='tag.aspx?ClassKind=<%=this.ClassKind%>'><img src="/administrator/images/nv7.png" alt="选择可用TAG [每个标签请用英文的逗号隔开例“,”] (可选) " name="" width="16" height="16" border="0"> 选择可用TAG</a> 
                      
                      [每个标签请用英文的逗号隔开例“,”] </span>(可选)    
                                
                                
                                </td>
                    <td align="center" nowrap bgcolor="#F4FBFF"><a href="#" title="点击关闭该项" id="_c7"><font color="#C2CCCC">X</font></a></td>
                    </tr>
                                            <tr>
                          <td align="right" valign="top" nowrap bgcolor="#F4FBFF">自定义URL： &nbsp;</td>
                          <td align="left" valign="top" nowrap bgcolor="#F4FBFF" class="_help"><label>
                            <input type="text" name="z_Url" id="z_Url" Class="input" runat=server >
                            <input name="Z_url_clk" type="checkbox" id="Z_url_clk" value="0"  runat=server >
                            启用自定义静态生成地址</label></td>
                          <td align="center" valign="top" nowrap bgcolor="#F4FBFF" class="_help">&nbsp;</td>
                        </tr>
                  <tr>
                    <td align="left" valign="top" nowrap bgcolor="#F4FBFF">
                       &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;  &nbsp; &nbsp;内容↓
                       ： &nbsp;</td>
                    <td align="left" valign="top" nowrap bgcolor="#F4FBFF" class="_help">(编辑器支持在线编辑粘贴内容时请清除原有内容格式)</td>
                    <td align="center" valign="top" nowrap bgcolor="#F4FBFF" class="_help"><a href="#" title="点击关闭该项"  id="_c8"><font color="#C2CCCC">X</font></a></td>
                    </tr>
                  <tr>
                    <td colspan="3" align="left" valign="top" nowrap bgcolor="#F4FBFF"><FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server"  EditorAreaCSS="/App_Templet/SystemCss/FckCss.css" BasePath="../FCKedit/" Height="400px" ToolbarSet="ROY" Width="100%" Value=""></FCKeditorV2:FCKeditor>         </td>
                  </tr>
                  <tr>
                    <td height="50" colspan="3" align="left" nowrap bgcolor="#F4FBFF">&nbsp;
&nbsp;
<asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="/administrator/images/submit-bt.gif" onclick="ImageButton_add_Click" />
                      &nbsp; &nbsp;<span class="_help">(确认编辑/参考注意事项)</span></td>
                    </tr>
                </table>
              </td>
              </tr>
            </table></td>
        </tr>
      </table>
                    
                    </div>
                    <div class="TabbedPanelsContent">
                    
                      <%=From_Out()%>
                      
                    </div>
                    <div class="TabbedPanelsContent">
                    </div>
                  </div>
                </div>

      </td>
    </tr>
  </table>
</form>  

<script type="text/javascript">

//删除上传的图片
$("#del_pic").click(function ()  
	{
       $("#pic_img").attr("src","/administrator/images/no_pic.gif"); 
       $("#txtpic").val(""); 
	}
)

<%if(!IS_IN("属性")){%>
       $("#add_table tr:eq(3)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("关键字")){%>
	   $("#add_table tr:eq(6)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("摘要")){%>
	   $("#add_table tr:eq(7)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("形象图")){%>
	   $("#add_table tr:eq(9)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("链接")){%>
	   $("#add_table tr:eq(10)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("跳转")){%>
	   $("#add_table tr:eq(11)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("标签")){%>
	   $("#add_table tr:eq(12)").fadeOut("slow"); 
<%}%>

//自定义模式
$("#_ms_2").click(function () 
    
	{ 
       <%if(!IS_IN("属性")){%>
       $("#add_table tr:eq(2)").fadeOut("slow"); 
	 
<%}%>
<%if(!IS_IN("关键字")){%>
	   $("#add_table tr:eq(5)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("摘要")){%>
	   $("#add_table tr:eq(6)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("形象图")){%>
	   $("#add_table tr:eq(8)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("链接")){%>
	   $("#add_table tr:eq(9)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("跳转")){%>
	   $("#add_table tr:eq(10)").fadeOut("slow"); 
<%}%>
<%if(!IS_IN("标签")){%>
	   $("#add_table tr:eq(11)").fadeOut("slow"); 
<%}%>
    }
	
); 

//详细模式
$("#_ms_0").click(function () 
    
	{ 
       $("#add_table tr:hidden").fadeIn("slow");
    }
	
); 
//简单模式
$("#_ms_1").click(function () 
    
	{ 
	   $("#add_table tr:eq(2)").fadeOut("slow"); 
       $("#add_table tr:eq(3)").fadeOut("slow"); 
	   $("#add_table tr:eq(4)").fadeOut("slow"); 
       $("#add_table tr:eq(5)").fadeOut("slow"); 
	   $("#add_table tr:eq(6)").fadeOut("slow"); 
       $("#add_table tr:eq(8)").fadeOut("slow"); 
	   $("#add_table tr:eq(9)").fadeOut("slow"); 
       $("#add_table tr:eq(10)").fadeOut("slow"); 
	   $("#add_table tr:eq(11)").fadeOut("slow"); 
    }
	
);
//跳转模式
//$("#jumpurl_on_of").click(function () 
    
	//{ 
	//   $("#add_table tr:eq(12)").fadeOut("slow"); 
    //   $("#add_table tr:eq(13)").fadeOut("slow"); 
  //  }
	
//);
//X号 关闭按钮
$("#_c1").click(function (){$("#add_table tr:eq(2)").fadeOut("slow"); });
$("#_c2").click(function (){$("#add_table tr:eq(5)").fadeOut("slow"); });
$("#_c3").click(function (){$("#add_table tr:eq(6)").fadeOut("slow"); });
$("#_c4").click(function (){$("#add_table tr:eq(8)").fadeOut("slow"); });
$("#_c5").click(function (){$("#add_table tr:eq(9)").fadeOut("slow"); });
$("#_c6").click(function (){$("#add_table tr:eq(10)").fadeOut("slow"); });
$("#_c7").click(function (){$("#add_table tr:eq(11)").fadeOut("slow"); });
$("#_c8").click(function (){$("#add_table tr:eq(12)").fadeOut("slow");$("#add_table tr:eq(13)").fadeOut("slow"); });
var TabbedPanels1 = new Spry.Widget.TabbedPanels("TabbedPanels1");
</script>
  
  
   
</body>
</html>
