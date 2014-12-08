<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zjsf.aspx.cs" Inherits="ROYcms.UI.Admin.App_Templet.Default.Zjsf" %>

<!DOCTYPE HTML>
<!--[if lt IE 7]><html class="no-js lt-ie9 lt-ie8 lt-ie7"><![endif]-->
<!--[if IE 7]><html class="no-js lt-ie9 lt-ie8"><![endif]-->
<!--[if IE 8]><html class="no-js lt-ie9"><![endif]-->
<!--[if gt IE 8]><!--><html class="no-js"><!--<![endif]-->
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=7" />
<title>水费查询/缴费</title>
<meta name="keywords" content='水费查询/缴费'>
<meta name="description" content='水费查询/缴费'>


<CMS:Include ID="Include1" Path="/App_Templet/Default/Resources.html" runat=server />
        <script language="JavaScript" type="text/JavaScript" src="/administrator/js/jquery-ui.js"></script>

<link href="/administrator/css/jquery-ui.css" rel="stylesheet" type="text/css" />
</head>
<body>
<!--Header-->
<CMS:Include ID="Include2" Path="/App_Templet/Default/Header.html" runat=server />
<!--/Header-->
    <form runat="server">
<div class="ct2_r wp cl">
  <div class="banner2 mb-10"><img width="980"  src="/update/yingyeting.jpg"></div>
  <!--breadcrumb-->
  <nav class="breadcrumb mb-10"> <a href="/" class="toHome">首页</a> <span class="to">to</span> 水费查询/缴费</nav>
  <!--/breadcrumb-->
  <div class="cl">
     <article class="mn cl mb-10">
      <div class="bk_1 bg1">
        <div class="title4 cl"><span class="l">水费查询/缴费</span><span class="r">
            <a style="font-size:14px;" id="view_zfbz" class="maincolor" href="#zfbz">查看资费标准</a></span></div>
        <!--登录前-->
        <section class="pd-20" style="width:300px; margin:0 auto">
          <h3 class="f16 mb-20" style="text-align:center">身份验证</h3>
     
            <div class="cl mb-20">
              <div class="inputbar cl">
                <label for="quyu" id="lbquyu">用户区域：</label>
                  <asp:DropDownList ID="quyu" runat="server">
                      <asp:ListItem>端州城区</asp:ListItem>
                      <asp:ListItem>鼎湖城区</asp:ListItem>
                      <asp:ListItem>广利</asp:ListItem>
                       <asp:ListItem>莲花</asp:ListItem>
                       <asp:ListItem>永安</asp:ListItem>
                       <asp:ListItem>封开县城</asp:ListItem>
                       <asp:ListItem>广宁县城</asp:ListItem>
                  </asp:DropDownList>

              </div>
            </div>
              <%if (ROYcms.Common.Session.Get("User_id") == null)
                { %>
            <div class="cl mb-20">
              <div class="inputbar cl">
                <label for="user_id" id="lbuser_id">用户编号：</label>
                  <asp:TextBox ID="username" runat="server"></asp:TextBox>
              
              </div>
            </div>
            <div class="cl mb-20">
              <div class="inputbar cl">
                <label for="password" id="lbpassword">服务密码：</label>
                 <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
              </div>
            </div>
            <div style="padding-left:64px">
              <asp:Button ID="Button_get" runat="server" Text=" 确 认 " CssClass="btn primary" OnClick="Button_get_Click" />
              <input class="btn" type="reset" value=" 重 置 ">
            </div>
              <%} else{%>

              授权成功 当前用户编号：<% =ROYcms.Common.Session.Get("User_id")  %>
              <%} %>
        
        </section>
        <section class="content pd-20">
          <h3 class="c_red">温馨提示：</h3>
          <ul class="">
            <li>1、服务密码是为方便用户网上服务提供的安全认证保障，第一次使用的用户默认服务密码为用户登记过的电话号码，验证通过后即可查询水费和订阅水费，亦可修改服务密码；</li>
            <li>2、若用户未登记过电话号码或者服务密码出错，可拨打水务服务热线 <strong>2828226</strong> 或到肇水集团客户中心咨询。</li>
          </ul>
        </section>
        <!--/登录前--> 
        
        <!--登录后查询缴费-->
        <section class="pd-20">
          <div style="text-align:center" class="mb-15">
              <asp:Repeater ID="Repeater_list" runat="server">
                  <ItemTemplate>

                      <%#Eval("") %>
                  </ItemTemplate>
              </asp:Repeater>
              起始月份：

           
           
              <asp:TextBox ID="starTime" runat="server"></asp:TextBox>至
              <asp:TextBox ID="endTime" runat="server"></asp:TextBox>
              
                <script>
                    $(document).ready(function () {
                        $("#starTime,#endTime").datepicker();
                    });
              </script>

              <asp:Button ID="Button_getval" runat="server" Text=" 查 询 " CssClass="btn primary" OnClick="Button_getval_Click" />
          </div>
          <table class="table_2" width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <th scope="col">计费年月</th>
              <th scope="col">本月行度</th>
              <th scope="col">抄表日期</th>
              <th scope="col">缴费日期</th>
              <th scope="col">用水量</th>
              <th scope="col">水费金额</th>
              <th scope="col">阶梯水费2</th>
              <th scope="col">阶梯水费3</th>
              <th scope="col">混合水费</th>
              <th scope="col">污水费</th>
              <th scope="col">超计划金额</th>
              <th scope="col">违约金</th>
              <th scope="col">混合污水费</th>
              <th scope="col">分摊消防表费</th>
              <th scope="col">垃圾费</th>
              <th scope="col">合计金额</th>
              <th scope="col">缴费情况</th>
            </tr>
            <tr>
              <td>201304</td>
              <td>232</td>
              <td>20130416</td>
              <td>20130323</td>
              <td>6</td>
              <td>7.80</td>
              <td>0.00</td>
              <td>0.00</td>
              <td>0.00</td>
              <td>5.04</td>
              <td>0.00</td>
              <td>0.12</td>
              <td>0.00</td>
              <td>0.00</td>
              <td>11</td>
              <td class="maincolor">25.26</td>
              <td><a href="#" class="jf_no" style="color:#136EC2">缴费</a></td>
            </tr>
            <tr>
              <td>201303</td>
              <td>232</td>
              <td>20130416</td>
              <td>20130323</td>
              <td>6</td>
              <td>7.80</td>
              <td>0.00</td>
              <td>0.00</td>
              <td>0.00</td>
              <td>5.04</td>
              <td>0.00</td>
              <td>0.12</td>
              <td>0.00</td>
              <td>0.00</td>
              <td>11</td>
              <td class="maincolor">25.26</td>
              <td><span class="jf_ok">已缴费</span></td>
            </tr>
          </table>
        </section>
        <!--登录后查询缴费-->
        <section id="zfbz" class="content pd-20">
          <h3 class="cl mb-15"><span class="l">资费标准：</span><a href="#top" id="hide_zfbz" class="r maincolor" style="font-size:14px; font-weight:normal; text-decoration:underline">收起</a></h3>
          <div>
            <table class="table_1" width="100%" cellspacing="0" cellpadding="0" border="0">
              <tbody>
                <tr>
                  <th width="6%">项目</th>
                  <th width="27%">名称</th>
                  <th width="11%">计量单位</th>
                  <th colspan="2">单价（元）</th>
                  <th width="23%">收费依据</th>
                </tr>
                <tr>
                  <td rowspan="6">水 费</td>
                  <td rowspan="3">居民生活用水</td>
                  <td rowspan="3" align="center">m<sup>3</sup></td>
                  <td width="25%">30立方米（含）及以下</td>
                  <td width="8%">1.30</td>
                  <td rowspan="6"><span style="FONT-SIZE: 10pt">肇庆市物价局文件 肇价[2012]75号文,从二0一二年五月十五日起执行</span></td>
                </tr>
                <tr>
                  <td>30立方米（以上）至35立方米（含）</td>
                  <td>1.95</td>
                </tr>
                <tr>
                  <td>35立方米以上</td>
                  <td>2.60</td>
                </tr>
                <tr>
                  <td>工业、机关团体用水</td>
                  <td align="center">m<sup>3</sup></td>
                  <td colspan="2" align="center">1.60</td>
                </tr>
                <tr>
                  <td>商业、服务、建筑用水</td>
                  <td align="center">m<sup>3</sup></td>
                  <td colspan="2" align="center">1.90</td>
                </tr>
                <tr>
                  <td>特种行业用水</td>
                  <td align="center">m<sup>3</sup></td>
                  <td colspan="2" align="center">2.30</td>
                </tr>
                <tr>
                  <td rowspan="4">污水处理费</td>
                  <td>居民生活（含消防、绿化、环卫）用水</td>
                  <td align="center">m<sup>3</sup></td>
                  <td colspan="2" align="center">0.80</td>
                  <td rowspan="4">肇庆市物价局肇价［2010］25号文件，从2010年4月1日起调整。(污水处理费按排水量计算,排水量按用水量90%折算)</td>
                </tr>
                <tr>
                  <td>工业、机关团体用水</td>
                  <td align="center">m<sup>3</sup></td>
                  <td colspan="2" align="center">1.30</td>
                </tr>
                <tr>
                  <td>商业、服务、建筑用水</td>
                  <td align="center">m<sup>3</sup></td>
                  <td colspan="2" align="center">1.50</td>
                </tr>
                <tr>
                  <td>特种行业用水</td>
                  <td align="center">m<sup>3</sup></td>
                  <td colspan="2" align="center">1.80</td>
                </tr>
                <tr>
                  <td>代收费</td>
                  <td>垃圾费</td>
                  <td colspan="3">按市人民政府有关规定执行（垃圾费咨询电话：2832977）</td>
                  <td><span style="FONT-SIZE:10pt">市人民政府肇府办函[2006]28号文</span></td>
                </tr>
              </tbody>
            </table>
          </div>
        </section>
      </div>
    </article>
      <aside class="sd">
      <nav class="leftmenu2">
        <p id="leftmenu1"><a href="servers.html">水费查询</a></p>
        <p id="leftmenu2"><a href="Zjsf.aspx">网上缴费</a></p>
        <p id="leftmenu3"><a href="message.html">在线留言</a></p>
        <p id="leftmenu4"><a href="Zyewu.aspx">业务办理</a></p>
        <p id="leftmenu5"><a href="/ucenter/GetPassword.aspx">修改密码</a></p>
        <p id="leftmenu6"><a href="/ucenter/logout.aspx">注销</a></p>
      </nav>
    </aside>
  </div>
</div></form>
<!--Footer-->
<CMS:Include ID="Include3" Path="/App_Templet/Default/Footer.html" runat=server />
<!--/Footer-->
</body>
</html>
