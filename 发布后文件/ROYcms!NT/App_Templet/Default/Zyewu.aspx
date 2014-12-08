<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zyewu.aspx.cs" Inherits="ROYcms.UI.Zyewu" %>

<!DOCTYPE HTML>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"><![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"><![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"><![endif]-->
<!--[if gt IE 8]><!--><html class="no-js"><!--<![endif]-->
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<title>业务申请</title>
<meta name="keywords" content='业务申请'>
<meta name="description" content='业务申请'>
<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
    <link href="/administrator/editor/themes/default/default.css" rel="stylesheet">
  <script type="text/javascript" charset="utf-8" src="/administrator/editor/kindeditor.js"></script>
        <script type="text/javascript" charset="utf-8" src="/administrator/editor/lang/zh_CN.js"></script>
</head>
<body>
   
<!--Header-->
<CMS:Include ID="Include2" Path="/App_Templet/Default/Header.html" runat=server />
<!--/Header-->
     <form runat="server">
<div class="ct2_r wp cl">
  <div class="banner2 mb-10"><img width="980" src="/update/yingyeting.jpg"></div>
  <!--breadcrumb-->
  <nav class="breadcrumb mb-10"> <a href="/" class="toHome">首页</a> <span class="to">to</span>业务申请</nav>
  <!--/breadcrumb-->
  <div class="cl">
    <article class="mn cl mb-10">
      <div id="yewushenqing" class="bk_1 bg1">
        <div class="title4 cl"><span class="l">业务申请</span></div>
        <div class="tabbar cl"><span>网上报装申请</span><span>代扣电子签约</span><span>电子账单申请</span></div>
        <section class="tabcon pd-20">
          <table class="table_1" width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <th colspan="4" scope="col" style="font-size:18px; text-align:center; padding:10px 0">填写申报资料<span style="font-size:14px; color:red">(带*的必填)</span></th>
            </tr>
            <tr>
              <td width="80">您的姓名：</td>
              <td colspan="3" nowrap="nowrap"><asp:TextBox id="txtName" runat="server" Width="200px"></asp:TextBox>                <span class="c_red">*</span></td>
            </tr>
            <tr>
              <td>您的地址：</td>
              <td colspan="3" nowrap="nowrap"><asp:TextBox id="txtaddress" runat="server" Width="491px"></asp:TextBox>                <span class="c_red">*</span></td>
            </tr>
            <tr>
              <td>证件类型：</td>
              <td width="200" nowrap="nowrap"><select name="" size="1" style="width:150px">
                <option value="1">身份证</option>
                <option value="2">军官证</option>
              </select>
                <span class="c_red">*</span></td>
              <td width="80" nowrap="nowrap">证件号码：</td>
              <td nowrap="nowrap"><asp:TextBox id="txtsId" runat="server" Width="200px"></asp:TextBox>                <span class="c_red">*</span></td>
            </tr>
            <tr>
              <td>移动电话：</td>
              <td nowrap="nowrap"><asp:TextBox id="txttel" runat="server" Width="200px"></asp:TextBox>                <span class="c_red">*</span></td>
              <td nowrap="nowrap">固定电话：</td>
              <td nowrap="nowrap"><asp:TextBox id="txtphone" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
              <td>E-mail：</td>
              <td nowrap="nowrap"><asp:TextBox id="txtemail" runat="server" Width="200px"></asp:TextBox></td>
              <td nowrap="nowrap">QQ：</td>
              <td nowrap="nowrap"><asp:TextBox id="txtqq" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
              <td>装表数量：</td>
              <td colspan="3" nowrap="nowrap"><asp:TextBox id="txtnum" runat="server" Width="200px"></asp:TextBox>                <span class="c_red">*</span></td>
            </tr>
            <tr>
              <td valign="top">申请理由：</td>
              <td colspan="3" nowrap="nowrap"><label for="textfield"></label>
                <asp:TextBox id="txtReason" runat="server" Width="266px" Height="71px" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
              <td valign="top">备注：</td>
              <td colspan="3" nowrap="nowrap"><asp:TextBox id="txtRemark" runat="server" Width="265px" Height="79px" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
      </table>
<div style="text-align:center; margin-top:20px">
  <asp:Button ID="btnSave" runat="server" Text=" 确 认 "  OnClick="btnSave_Click" class="btn primary"></asp:Button>
  <input type="reset" value=" 重 置 " class="btn">
</div>
        </section>
     
           
   
       
        <section class="tabcon pd-20">
            
              <%if (ROYcms.Common.Session.Get("User_id") != null){ %>   
          <table class="table_1" width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <th colspan="4" scope="col" style="font-size:18px; text-align:center; padding:10px 0">填写代扣电子签约资料<span style="font-size:14px; color:red">(带*的必填)</span></th>
            </tr>

            <tr>
              <td width="80">开户银行：</td>
              <td width="200" nowrap="nowrap"><span class="c_red">
                <asp:TextBox ID="txtBankAccount" runat="server" Width="200px"></asp:TextBox>
                *</span></td>
              <td width="80" nowrap="nowrap">开户名称：                </td>
              <td nowrap="nowrap"><span class="c_red">
                <asp:TextBox ID="txtBankName" runat="server" Width="200px"></asp:TextBox>
                *</span></td>
            </tr>
            <tr>
              <td>帐号：</td>
              <td colspan="3" nowrap="nowrap"><asp:TextBox ID="txtAccount" runat="server" Width="200px"></asp:TextBox>                <span class="c_red">*</span></td>
            </tr>
            <tr>
              <td>身份证号：</td>
              <td colspan="3" nowrap="nowrap"><asp:TextBox ID="txtsId2" runat="server" Width="200px"></asp:TextBox>                <span class="c_red">*</span></td>
            </tr>
            <tr>
              <td>联系人：</td>
              <td nowrap="nowrap"><asp:TextBox ID="txtContact" runat="server" Width="200px"></asp:TextBox></td>
              <td nowrap="nowrap">联系电话：</td>
              <td nowrap="nowrap"><span class="c_red">
                <asp:TextBox ID="txtTel2" runat="server" Width="200px"></asp:TextBox>
                *</span></td>
            </tr>
            <tr>
              <td>资料上传：</td>
              <td colspan="3" nowrap="nowrap">  <asp:TextBox ID="txtpic" runat="server" Width="200px"></asp:TextBox>


                   <a href="#" class="btnSearch" id="ProductPic_click" style=" padding:3px; margin-left:5px;">选择文件</a>
                
                
                <script>
                    KindEditor.ready(function (K) {
                        var editor = K.editor({
                            cssPath: '/Administrator/Editor/plugins/code/prettify.css',
                            uploadJson: '/Administrator/Editor/C/upload_json.ashx?root=ZS,YEWU',
                            fileManagerJson: '/Administrator/Editor/C/file_manager_json.ashx?root=ZS,YEWU00000000000',
                            allowFileManager: true
                        });
                        K('#ProductPic_click').click(function () {
                            editor.loadPlugin('image', function () {
                                editor.plugin.imageDialog({
                                    imageUrl: K('#txtpic').val(),
                                    clickFn: function (url, title, width, height, border, align) {
                                        K('#txtpic').val(url);

                                        editor.hideDialog();
                                    }
                                });
                            });
                        });
                    });
		                        </script>
                  </td>
            </tr>
        </table>
          <div style="text-align:center; margin-top:20px">
             <asp:Button ID="btnSave2" runat="server" Text=" 确 认 "
                    OnClick="btnSave2_Click" class="btn primary" ></asp:Button>
              <input type="reset" value=" 重 置 " class="btn">
          </div>
                                    <%}else{ %>


          <a href="/login.html">您还没登录请先登录</a>

          <%} %>
        </section>
                  <section class="tabcon pd-20">

   <%if (ROYcms.Common.Session.Get("User_id") != null){ %>   



          <table class="table_1" width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <th colspan="4" scope="col" style="font-size:18px; text-align:center; padding:10px 0">
                  电子账单申请<span style="font-size:14px; color:red">(带*的必填)</span></th>
            </tr>

            <tr>
              <td width="80">Email：</td>
              <td width="200" nowrap="nowrap"><span class="c_red">
                <asp:TextBox ID="txtEmail3" runat="server" Width="200px"></asp:TextBox>
                *</span></td>
              <td width="80" nowrap="nowrap">内容：                </td>
              <td nowrap="nowrap"><span class="c_red">
                <asp:TextBox ID="txtContents3" runat="server" Width="200px"></asp:TextBox>
                *</span></td>
            </tr>
            <tr>
              <td>备注：</td>
              <td colspan="3" nowrap="nowrap"><asp:TextBox ID="txtRemark3" runat="server" Width="200px"></asp:TextBox>      </td>
            </tr>
           
          
          
        </table>
          <div style="text-align:center; margin-top:20px">
             <asp:Button ID="btnSave3" runat="server" Text=" 确 认 "
                    OnClick="btnSave3_Click" class="btn primary" ></asp:Button>
              <input type="reset" value=" 重 置 " class="btn">
          </div>
                        <%}else{ %>


          <a href="/login.html">您还没登录请先登录</a>

          <%} %>
        </section>
           

      </div>
    </article>
      <aside class="sd">
    <nav class="leftmenu2">
        <p id="leftmenu1"><a href="servers.html">水费查询</a></p>
        <p id="leftmenu2"><a href="Zjsf.aspx">网上缴费</a></p>
        <p id="leftmenu3"><a href="message.html">在线留言</a></p>
        <p id="leftmenu4"><a href="/Zyewu.aspx">业务办理</a></p>
        <p id="leftmenu5"><a href="/ucenter/GetPassword.aspx">修改密码</a></p>
        <p id="leftmenu6"><a href="/ucenter/logout.aspx">注销</a></p>
      </nav>
    </aside>
  </div>
</div>

     </form>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
        
</body>
</html>
