<%@ Page Language="C#" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html >
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Edit or Add  ROYcms!NT</title>
<script type="text/javascript" src="/administrator/FCKedit/fckeditor.js"></script>
<script type="text/javascript">
// FCKeditor_OnComplete is a special function that is called when an editor
// instance is loaded ad available to the API. It must be named exactly in
// this way.
function ExecuteCommand( num,commandName )
{
    // Get the editor instance that we want to interact with.
    var oEditor = FCKeditorAPI.GetInstance( num ) ;

    // Execute the command.
    oEditor.Commands.GetCommand( commandName ).Execute() ;
}
    </script>
</head>
<body>
<Resources:Resources ID="Resources1" runat="server" />
<div id="wrap">
  <table width="100%" border="0" class="tiao_top" style="margin-bottom:4px;">
    <tr>
      <td width="77%" nowrap><div class="tiao_con"><a href="#"><img align="absmiddle" src="/administrator/images/nv6.png" />保存</a> <a href="#"><img align="absmiddle" src="/administrator/images/nv8.png" />新建</a> <a href="#"><img align="absmiddle" src="/administrator/images/nv9.png" />编辑</a> <a href="#"><img align="absmiddle" src="/administrator/images/pill.png" />预览</a> <a href="#"><img align="absmiddle" src="/administrator/images/rosette.png" />关闭</a></div></td>
      <td width="23%" align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
    </tr>
  </table>
  <table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
      <td style="background:#666; text-align:center; width:100%;"><div style=" TEXT-ALIGN: center; BACKGROUND-COLOR: #666666; WIDTH: 100%;" id=_DivContainer>
          <table style="MARGIN: 5px auto" id="_Table1" border="0" cellpadding="20" cellspacing="10" width="850" bgcolor=#ffffff>
            <tbody>
              <tr>
                <td><table cellspacing=4 cellpadding=2 width="100%">
                    <tbody>
                      <tr>
                        <td><strong>信息标题</strong></td>
                        <td align="left" valign="middle"><input name="" type="text" class="input" ID="txttitle" size="78"  />
                          请填写标题
                          <label>
                            <input type="checkbox" ID="ding" class="cbox" align="absmiddle">
                            置顶</label>
                          <label>
                            <input type="checkbox" ID="tuijian"  class="cbox">
                            推荐</label>
                          <label>
                            <input type="checkbox" ID="switchs"  class="cbox">
                            发布</label></td>
                      </tr>
                      <tr  id=trShortTitle>
                        <td><strong>关键字</strong></td>
                        <td colspan=3 align=left><input 
                  style="WIDTH: 200px; " 
                  id=ShortTitle class=input size=50 name=ShortTitle />
                          [每个关键字请用英文的逗号隔开例“,”] (可选)</td>
                      </tr>
                      <tr>
                        <td><strong>形象图片</strong></td>
                        <td align="left"><table width="100%" border="0">
                            <tr>
                              <td width="10%" nowrap><img align="absmiddle" src="/administrator/images/no_pic.gif" width="16" height="16" alt="形象图片" />
                                <input type="text" class="input"></td>
                              <td width="73%"><input type="button" value="浏览..." id="Button_add_ll" class="sc">
                                <a href="/administrator/FileManager/template_Default.aspx" class="submodal-560-480" ><span class="chi">浏览服务器</span></a>(可选) </td>
                            </tr>
                          </table></td>
                      </tr>
                      <tr>
                        <td><strong>链接</strong></td>
                        <td align=left><p>
                            <input id=Keyword class=input size=50 name=keyword />
                          </p></td>
                      </tr>
                      <tr>
                        <td><strong>标签TAG</strong></td>
                        <td align=left><input name=URL class="input" id=URL  size=50 />
                          <span class="_help"> <a class="submodal-460-360" href='#'><img src="../images/eye.png" alt="选择可用TAG [每个标签请用英文的逗号隔开例“,”] (可选) " name="" width="16" height="16" border="0" align="absmiddle"> 选择可用TAG</a> [每个标签请用英文的逗号隔开例“,”] </span>(可选) </td>
                      </tr>
                    </tbody>
                  </table>
                  <!--高级选项-->
                  <div id=DivContent>
                    <table cellspacing=0 cellpadding=2 width="100%" height=206>
                      <tbody>
                        <tr>
                          <td align=middle valign="top"><script type="text/javascript">
var oFCKeditor = new FCKeditor('FCKeditor_1') ;
oFCKeditor.BasePath = "/administrator/FCKedit/";
oFCKeditor.Height = 500 ;

oFCKeditor.Value = '您可以在这里填写信息！' ;
oFCKeditor.Create() ;
</script></td>
                        </tr>
                      </tbody>
                    </table>
                  </div></td>
              </tr>
            </tbody>
          </table>
        </div></td>
      <td align="left" valign="top" id="right" style="background-color:#F2F2F2; padding-left:5px; padding-right:5px;" ><table width="100%">
          <TR>
            <TD class=themright ><TABLE border=0 cellSpacing=0 cellPadding=0 width="100%">
                <TBODY>
                  <TR>
                    <TD width=5>&nbsp;</TD>
                    <TD class=windowname><strong><IMG  align="absmiddle" id=id_AdvanceImg2  src="../images/control_play_blue.png" width="16" height="16" /> 信息属性</strong></TD>
                    <TD width=20>&nbsp;</TD>
                    <TD width=5>&nbsp;</TD>
                  </TR>
                </TBODY>
              </TABLE></TD>
          </TR>
          <TR id=LeftContent_TR2>
            <TD id=id_AdvanceTd3 class=thembg vAlign=top align=middle><TABLE  width="95%" border=0 align="center" cellPadding=0 cellSpacing=4 class=cellspacing style="background:#fff">
                <TBODY>
                  <TR vAlign=top align=left>
                    <TD noWrap valign="middle" >模板</TD>
                    <TD colspan="2"><LABEL>
                        <input  value=1  type=checkbox name=TemplateFlag2  class="cbox">
                        独立模板</LABEL></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD width="16%" noWrap valign="middle" >&nbsp;</TD>
                    <TD width="42%"><input type="text" class="input2" size="10"></TD>
                    <TD width="42%"><input type="button" value="浏览..." id="Button_add_ll2" class="sc" height="20px"></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD  valign="middle">生成</TD>
                    <TD colspan="2"><LABEL>
                        <input name="Z_url_clk2" type="checkbox" id="Z_url_clk2" value="0"  class="cbox">
                        启用自定义地址</LABEL></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD  valign="middle">&nbsp;</TD>
                    <TD width="84%" colspan="2"><INPUT id=Template class=input2 size=20 
                        name=Template 
                        condition="$('TemplateFlag').checked==true" 
                        verify="独立模板|NotNull">
                      <LABEL for=label></LABEL></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD  valign="middle">跳转</TD>
                    <TD colspan="2"><LABEL>
                        <input name="Z_url_clk" type="checkbox" id="Z_url_clk" value="0"  class="cbox">
                        启用自定义地址</LABEL></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD  valign="middle">&nbsp;</TD>
                    <TD colspan="2"><INPUT id=Template2 class=input2 size=20 ></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD  valign="middle">归档</TD>
                    <TD colspan="2"><INPUT style="FONT-FAMILY: Arial; FONT-SIZE: 10px"  id=ArchiveDate class=input2 value=2011-07-29 size=24 ></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD vAlign=center>摘要</TD>
                    <TD colspan="2"><TEXTAREA name=Summary cols=25 rows=3 class="input2" id=Summary style="WIDTH: 160px; height:36px;"></TEXTAREA></TD>
                  </TR>
                </TBODY>
            </TABLE></TD>
          </TR>
        </table>
        <table width="100%">
          <TR>
            <TD class=themright ><TABLE border=0 cellSpacing=0 cellPadding=0 width="100%">
                <TBODY>
                  <TR>
                    <TD width=5>&nbsp;</TD>
                    <TD class=windowname><strong><IMG  align="absmiddle" id=id_AdvanceImg  src="../images/control_play_blue.png" width="16" height="16" /> 扩展属性</strong></TD>
                    <TD width=5>&nbsp;</TD>
                  </TR>
                </TBODY>
              </TABLE></TD>
          </TR>
          <TR id=LeftContent_TR2>
            <TD id=id_AdvanceTd3 class=thembg vAlign=top align=middle><TABLE 
                  width="95%" border=0 align="center" cellPadding=0 cellSpacing=4 class=cellspacing style=" background:#fff">
                <TBODY>
                  <TR vAlign=top align=left>
                    <TD width="16%" noWrap valign="middle" >权限</TD>
                    <TD width="84%"><LABEL>
                        <INPUT 
                        id=TemplateFlag  value=1 
                        type=checkbox name=TemplateFlag  class="cbox">
                        启用访问权限</LABEL></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD  valign="middle">上线</TD>
                    <TD width="84%"><INPUT 
                        style="FONT-FAMILY: Arial; FONT-SIZE: 10px" 
                        id=PublishDate class=input2 size=14 name=text 
                        ztype="Date">
                      <LABEL for=label></LABEL></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD  valign="middle">归档</TD>
                    <TD><INPUT style="FONT-FAMILY: Arial; FONT-SIZE: 10px" 
                        id=ArchiveDate class=input2 value=2011-07-29 size=14 
                        name=text3 ztype="Date"></TD>
                  </TR>
                  <TR vAlign=top align=left>
                    <TD vAlign=center>摘要</TD>
                    <TD><TEXTAREA name=Summary2 cols=25 rows=3 class="input2" id=Summary2 style="WIDTH: 160px; height:36px;"></TEXTAREA></TD>
                  </TR>
                </TBODY>
            </TABLE></TD>
          </TR>
        </table></td>
    </tr>
  </table>
</div>
<style type="text/css">
#wrap {
	width:100%;
	border:0px;
}
.top {
	padding-left:10px;
}
.top a {
	color:#000;
	margin-right:10px;
	line-height:22px;
}
#right {
	line-height:22px;
	color:#ccc;
	font-size:12px;
	background-color:#F7FAFC;
	border: 1px solid #F7FAFC;
}
.input {
	height:22px;
	line-height:22px;
	color:#114477;
	vertical-align:middle;
	font-size:12px;
	border-top-width: 1px;
	border-right-width: 1px;
	border-bottom-width: 1px;
	border-left-width: 1px;
	border-top-style: solid;
	border-right-style: solid;
	border-bottom-style: solid;
	border-left-style: solid;
	border-top-color: #778899;
	border-right-color: #8899AA;
	border-bottom-color: #8899AA;
	border-left-color: #AABBCC;
	background-color:#F7FAFC;
}
.input2 {
	height:20px;
	line-height:22px;
	color:#114477;
	vertical-align:middle;
	font-size:12px;
	border-top-width: 1px;
	border-right-width: 1px;
	border-bottom-width: 1px;
	border-left-width: 1px;
	border-top-style: solid;
	border-right-style: solid;
	border-bottom-style: solid;
	border-left-style: solid;
	border-top-color: #778899;
	border-right-color: #8899AA;
	border-bottom-color: #8899AA;
	border-left-color: #AABBCC;
	background-color:#F7FAFC;
}
.cbox {
}
.sc {
	background:#FFF;
	width:55px;
	height:22px;
	text-align:center;
	border:#667788 1px solid;
	color:#0099DD;
}
.chi {
	text-align:center;
}
</style>
</body>
</html>
