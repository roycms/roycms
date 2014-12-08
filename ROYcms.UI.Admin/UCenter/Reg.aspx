<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UCenter.Administrator_reg"  %>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_name")%> -个人会员注册</title>
<style type="text/css">
<!--
.top {
	width: 750px;
	height: 60px;
	margin: auto;
	margin-bottom: 10px;
}
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	padding: 5px;
}
.top_title {
	width: 480px;
	height: 15px;
	background-color: #0066B3;
	color: #FFF;
	font-size: 13px;
	padding: 5px;
	float: left;
	margin-top: 30px;
	margin-left: 10px;
}
.logo {
	width: 240px;
	height: 60px;
	float: left;
}
.table_title {
	font-size: 12px;
	font-weight: bold;
	color: #000;
	line-height: 23px;
}
.table_title span {
	color: #666;
	font-weight: normal;
}
textarea {
	font-size: 12px;
	line-height: 23px;
	color: #999;
}
.copy_right {
	color: #666;
	width: 100%;
	height: 16px;
	margin-top: 20px;
	text-align: center;
	background-color: #F6F6F6;
	padding: 3px;
	font-size: 12px;
	border: 1px solid #F0F0F0;
    }
.top .top_title span {
	font-size: 10px;
	font-weight: normal;
	float: right;
	clear: none;
	margin-top:-13px;
}
.top_title1 {	width: 420px;
	height: 15px;
	background-color: #0066B3;
	color: #FFF;
	font-size: 13px;
	padding: 5px;
	float: right;
	margin-top: 30px;
	margin-left: 10px;
	margin-right: 2px;
}
.logo1 {	width: 300px;
	height: 78px;
	float: left;
}
.top_title {
	width: 420px;
	height: 15px;
	background-color: #0066B3;
	color: #FFF;
	font-size: 13px;
	padding: 5px;
	float: right;
	margin-top: 30px;
	margin-left: 10px;
	margin-right: 2px;
}
-->
</style>
<script src="../Administrator/js/SpryAssets/SpryValidationPassword.js" type="text/javascript"></script>
<script src="../Administrator/js/SpryAssets/SpryValidationConfirm.js" type="text/javascript"></script>
<script src="../Administrator/js/SpryAssets/SpryValidationTextField.js" type="text/javascript"></script>
<script src="../Administrator/js/SpryAssets/SpryValidationRadio.js" type="text/javascript"></script>
<link href="../Administrator/css/SpryAssets/SpryValidationPassword.css" rel="stylesheet" type="text/css">
<link href="../Administrator/css/SpryAssets/SpryValidationConfirm.css" rel="stylesheet" type="text/css">
<link href="../Administrator/css/SpryAssets/SpryValidationTextField.css" rel="stylesheet" type="text/css">
<link href="../Administrator/css/SpryAssets/SpryValidationRadio.css" rel="stylesheet" type="text/css">
</head>
<body>
<form id="UserRegForm" runat="server">
<table width="750" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td><div class="top">
      <div class="logo1"><img name="" src='<%=ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("logo") %>' alt="ROYcms! NT" /></div>
      <div class="top_title"><strong>个人用户注册</strong><span><%=ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_name")%> - ROYcms NT!</span></div>
    </div></td>
  </tr>
  <tr>
    <td><table width="100%" border="0" cellspacing="0">
      <tr>
        <td width="55%">&nbsp;</td>
        <td width="26%" class="table_title">第一步：填写基本信息</td>
        <td width="14%" class="table_title">注册完成</td>
        </tr>
    </table></td>
  </tr>
</table>
<table width="750" height="469" border="0" align="center" cellpadding="4" cellspacing="1" bordercolor="#E1E1E1">
  <tr>
    <td width="4" height="62" bgcolor="#E4E4E4">&nbsp;</td>
    <td colspan="2" bgcolor="#F7F7F7" class="table_title">用户名:
        <span id="sprytextfield1">
        <label> <br />
          <input type="text" name="txtname" id="txtname" runat="server" /> <a href="login.aspx" title="我已经注册了账户，我要登录">我已注册了账户</a><br />
        </label>
        <span class="textfieldRequiredMsg">请填写用户</span><span class="textfieldMaxCharsMsg">已超过最大字符数。</span><span class="textfieldMinCharsMsg">不符合最小字符数要求。</span></span>
      <span>不超过7个汉字，或14个字节(数字，字母和下划线)</span>
      </td>
    <td width="213" bgcolor="#F7F7F7">
      </td>
  </tr>
  <tr>
    <td height="50" bgcolor="#E4E4E4">&nbsp;</td>
    <td bgcolor="#F7F7F7" class="table_title">密码:<br />  
    
      <span id="sprypassword1">
      <input name="txtpassword" type="password" id="txtpassword" size="15" runat="server"  />
      <span class="passwordRequiredMsg">请填写密码</span> <span class="passwordMinCharsMsg"><br>
      不符合最小字符数要求。</span></span>
    </td>
    <td width="275" bgcolor="#F7F7F7"  class="table_title">重复密码:<br />
    <span id="spryconfirm1">
    <input name="txtpassword_same" type="password" id="txtpassword_same" size="15" runat="server"  />
     <span class="confirmRequiredMsg">请填写密码</span>
      <span class="confirmInvalidMsg">重复输入密码不匹配</span>
      
      </span>
    </td>
    <td rowspan="6" valign="top" bgcolor="#F7F7F7"></td>
  </tr>
  <tr>
    <td height="34" bgcolor="#E4E4E4">&nbsp;</td>
    <td colspan="2" bgcolor="#F7F7F7" class="table_title"><span>最少6个字符,不超过14个字符(数字，字母和下划线)</span></td>
    </tr>
  <tr>
    <td height="32" bgcolor="#E4E4E4">&nbsp;</td>
    <td colspan="2" bgcolor="#F7F7F7" class="table_title">
     性别:<br>
<span id="spryradio1">
        <label>
          <input type="radio" name="xingbie" value="男" id="xingbie_0" runat="server"  />
        男</label>
        
        <label>
          <input type="radio" name="xingbie" value="女" id="xingbie_1" runat="server"  />
          女</label>
        <span class="radioRequiredMsg">请选性别</span></span>
    </td>
    </tr>
  <tr>
    <td height="72" bgcolor="#E4E4E4">&nbsp;</td>
    <td colspan="2" bgcolor="#F7F7F7" class="table_title">电子邮件:<br />
      <span id="sprytextfield2">   
        <input type="text" name="txtemail" id="txtemail"  runat="server" />
        <span class="textfieldRequiredMsg">请填写您的邮件地址</span><span class="textfieldInvalidFormatMsg"> 不是有效的邮件地址</span></span>
      <br />
      <span>请输入有效的邮件地址，当密码遗失时凭此领取</span></td>
    </tr>
  <tr>
    <td height="68" bgcolor="#E4E4E4">&nbsp;</td>
    <td colspan="2" bgcolor="#F7F7F7" class="table_title">输入图中字符:<br />  
    
        <input name="yanzhengma" type="text" id="yanzhengma" size="12" runat="server"  />
    <img id="validateCode" src="~/Administrator/Img.ashx" onClick="this.src=this.src+'?1'"  alt="验证码" runat="server" /> <a  onClick="validateCode.src=validateCode.src+'?1'" title="看不清我要换一张">看不清？</a></td>
    </tr>
  <tr>
    <td height="35" bgcolor="#E4E4E4">&nbsp;</td>
    <td colspan="2" bgcolor="#F7F7F7" class="table_title">
        <asp:Button ID="Button_add" runat="server" Text="同意以下条款并提交"  onclick="UserReg_Click" />  
        <a href="login.aspx" title="我已经注册了账户，我要登录"> 我已注册了账户</a></td>
    </tr>
  <tr>
    <td bgcolor="#E4E4E4">&nbsp;</td>
    <td colspan="2" bgcolor="#F7F7F7"><label>
      <textarea name="textarea" cols="65" rows="5" readonly="readonly" id="textarea">一、总则

1．1　用户应当同意本协议的条款并按照页面上的提示完成全部的注册程序。用户在进行注册程序过程中点击"同意"按钮即表示用户与公司达成协议，完全接受本协议项下的全部条款。
1．2　用户注册成功后，将给予每个用户一个用户帐号及相应的密码，该用户帐号和密码由用户负责保管；用户应当对以其用户帐号进行的所有活动和事件负法律责任。
1．3　用户可以使用各个频道单项服务，当用户使用各单项服务时，用户的使用行为视为其对该单项服务的服务条款以及在该单项服务中发出的各类公告的同意。
1．4　会员服务协议以及各个频道单项服务条款和公告可由公司随时更新，且无需另行通知。您在使用相关服务时,应关注并遵守其所适用的相关条款。
　　您在使用提供的各项服务之前，应仔细阅读本服务协议。如您不同意本服务协议及/或随时对其的修改，您可以主动取消提供的服务；您一旦使用服务，即视为您已了解并完全同意本服务协议各项内容，包括对服务协议随时所做的任何修改，并成为用户。

二、注册信息和隐私保护

2．1　帐号（即用户ID）的所有权归，用户完成注册申请手续后，获得帐号的使用权。用户应提供及时、详尽及准确的个人资料，并不断更新注册资料，符合及时、详尽准确的要求。所有原始键入的资料将引用为注册资料。如果因注册信息不真实而引起的问题，并对问题发生所带来的后果，不负任何责任。
2．2　用户不应将其帐号、密码转让或出借予他人使用。如用户发现其帐号遭他人非法使用，应立即通知。因黑客行为或用户的保管疏忽导致帐号、密码遭他人非法使用，不承担任何责任。
2．3　不对外公开或向第三方提供单个用户的注册资料，除非：
（1）事先获得用户的明确授权；
（2）只有透露你的个人资料，才能提供你所要求的产品和服务；
（3）根据有关的法律法规要求；
（4）按照相关政府主管部门的要求；
（5）为维护的合法权益。
2．4　在你注册帐户，使用其他产品或服务，访问网页, 或参加促销和有奖游戏时，会收集你的个人身份识别资料，并会将这些资料用于：改进为你提供的服务及网页内容。

三、使用规则

3．1　用户在使用服务时，必须遵守中华人民共和国相关法律法规的规定，用户应同意将不会利用本服务进行任何违法或不正当的活动，包括但不限于下列行为∶
（1）上载、展示、张贴、传播或以其它方式传送含有下列内容之一的信息：
1） 反对宪法所确定的基本原则的； 2） 危害国家安全，泄露国家秘密，颠覆国家政权，破坏国家统一的； 3） 损害国家荣誉和利益的； 4） 煽动民族仇恨、民族歧视、破坏民族团结的； 5） 破坏国家宗教政策，宣扬邪教和封建迷信的； 6） 散布谣言，扰乱社会秩序，破坏社会稳定的； 7） 散布淫秽、色情、赌博、暴力、凶杀、恐怖或者教唆犯罪的； 8） 侮辱或者诽谤他人，侵害他人合法权利的； 9） 含有虚假、有害、胁迫、侵害他人隐私、骚扰、侵害、中伤、粗俗、猥亵、或其它道德上令人反感的内容； 10） 含有中国法律、法规、规章、条例以及任何具有法律效力之规范所限制或禁止的其它内容的； 
（2）不得为任何非法目的而使用网络服务系统；
（3）不利用服务从事以下活动：
1) 未经允许，进入计算机信息网络或者使用计算机信息网络资源的；
2) 未经允许，对计算机信息网络功能进行删除、修改或者增加的；
3) 未经允许，对进入计算机信息网络中存储、处理或者传输的数据和应用程序进行删除、修改或者增加的；
4) 故意制作、传播计算机病毒等破坏性程序的；
5) 其他危害计算机信息网络安全的行为。
3．2　用户违反本协议或相关的服务条款的规定，导致或产生的任何第三方主张的任何索赔、要求或损失，包括合理的律师费，您同意赔偿与合作公司、关联公司，并使之免受损害。对此，有权视用户的行为性质，采取包括但不限于删除用户发布信息内容、暂停使用许可、终止服务、限制使用、回收帐号、追究法律责任等措施。对恶意注册帐号或利用帐号进行违法活动、捣乱、骚扰、欺骗、其他用户以及其他违反本协议的行为，有权回收其帐号。同时，公司会视司法部门的要求，协助调查。
3．3　用户不得对本服务任何部分或本服务之使用或获得，进行复制、拷贝、出售、转售或用于任何其它商业目的。
3．4　用户须对自己在使用服务过程中的行为承担法律责任。用户承担法律责任的形式包括但不限于：对受到侵害者进行赔偿，以及在公司首先承担了因用户行为导致的行政处罚或侵权损害赔偿责任后，用户应给予公司等额的赔偿。 

四、服务内容

4．1　网络服务的具体内容由根据实际情况提供。
4．2　除非本服务协议另有其它明示规定，所推出的新产品、新功能、新服务，均受到本服务协议之规范。
4．3　为使用本服务，您必须能够自行经有法律资格对您提供互联网接入服务的第三方，进入国际互联网，并应自行支付相关服务费用。此外，您必须自行配备及负责与国际联网连线所需之一切必要装备，包括计算机、数据机或其它存取装置。
4．4　鉴于网络服务的特殊性，用户同意有权不经事先通知，随时变更、中断或终止部分或全部的网络服务（包括收费网络服务）。不担保网络服务不会中断，对网络服务的及时性、安全性、准确性也都不作担保。
4．5　需要定期或不定期地对提供网络服务的平台或相关的设备进行检修或者维护，如因此类情况而造成网络服务（包括收费网络服务）在合理时间内的中断，无需为此承担任何责任。保留不经事先通知为维修保养、升级或其它目的暂停本服务任何部分的权利。
4．6　本服务或第三人可提供与其它国际互联网上之网站或资源之链接。由于无法控制这些网站及资源，您了解并同意，此类网站或资源是否可供利用，不予负责，存在或源于此类网站或资源之任何内容、广告、产品或其它资料，亦不予保证或负责。因使用或依赖任何此类网站或资源发布的或经由此类网站或资源获得的任何内容、商品或服务所产生的任何损害或损失，不承担任何责任。
4．7　用户明确同意其使用网络服务所存在的风险将完全由其自己承担。用户理解并接受下载或通过服务取得的任何信息资料取决于用户自己，并由其承担系统受损、资料丢失以及其它任何风险。对在服务网上得到的任何商品购物服务、交易进程、招聘信息，都不作担保。
4．8　6个月未登陆的帐号，保留关闭的权利。
4．9　有权于任何时间暂时或永久修改或终止本服务（或其任何部分），而无论其通知与否，对用户和任何第三人均无需承担任何责任。
4．10　终止服务
您同意得基于其自行之考虑，因任何理由，包含但不限于长时间未使用，或认为您已经违反本服务协议的文字及精神，终止您的密码、帐号或本服务之使用（或服务之任何部分），并将您在本服务内任何内容加以移除并删除。您同意依本服务协议任何规定提供之本服务，无需进行事先通知即可中断或终止，您承认并同意，可立即关闭或删除您的帐号及您帐号中所有相关信息及文件，及/或禁止继续使用前述文件或本服务。此外，您同意若本服务之使用被中断或终止或您的帐号及相关信息和文件被关闭或删除，对您或任何第三人均不承担任何责任。

五、知识产权和其他合法权益（包括但不限于名誉权、商誉权）

5．1　用户专属权利
尊重他人知识产权和合法权益，呼吁用户也要同样尊重知识产权和他人合法权益。若您认为您的知识产权或其他合法权益被侵犯，请按照以下说明向提供资料∶
　 请注意：如果权利通知的陈述失实，权利通知提交者将承担对由此造成的全部法律责任（包括但不限于赔偿各种费用及律师费）。如果上述个人或单位不确定网络上可获取的资料是否侵犯了其知识产权和其他合法权益，建议该个人或单位首先咨询专业人士。 
　 为了有效处理上述个人或单位的权利通知，请使用以下格式（包括各条款的序号）： 
　　 1. 权利人对涉嫌侵权内容拥有知识产权或其他合法权益和/或依法可以行使知识产权或其他合法权益的权属证明；
　　 2. 请充分、明确地描述被侵犯了知识产权或其他合法权益的情况并请提供涉嫌侵权的第三方网址（如果有）。
　　 3. 请指明涉嫌侵权网页的哪些内容侵犯了第2项中列明的权利。
　　 4. 请提供权利人具体的联络信息，包括姓名、身份证或护照复印件（对自然人）、单位登记证明复印件（对单位）、通信地址、电话号码、传真和电子邮件。
　　 5. 请提供涉嫌侵权内容在信息网络上的位置（如指明您举报的含有侵权内容的出处，即：指网页地址或网页内的位置）以便我们与您举报的含有侵权内容的网页的所有权人/管理人联系。
　　 6. 请在权利通知中加入如下关于通知内容真实性的声明： “我保证，本通知中所述信息是充分、真实、准确的，如果本权利通知内容不完全属实，本人将承担由此产生的一切法律责任。”
　　 7. 请您签署该文件，如果您是依法成立的机构或组织，请您加盖公章。 
　 请您把以上资料和联络方式书面发往以下地址：　　
中国北京市海淀区海淀大街38号银科大厦19层
　　 公司 投诉组
　　 邮政编码：100080
5．2　对于用户通过服务（包括但不限于贴吧、知道、MP3、影视等）上传到网站上可公开获取区域的任何内容，用户同意在全世界范围内具有免费的、永久性的、不可撤销的、非独家的和完全再许可的权利和许可，以使用、复制、修改、改编、出版、翻译、据以创作衍生作品、传播、表演和展示此等内容（整体或部分），和/或将此等内容编入当前已知的或以后开发的其他任何形式的作品、媒体或技术中。
5．3　拥有本网站内所有资料的版权。任何被授权的浏览、复制、打印和传播属于本网站内的资料必须符合以下条件：
所有的资料和图象均以获得信息为目的；
　　 所有的资料和图象均不得用于商业目的；
　　 所有的资料、图象及其任何部分都必须包括此版权声明；
　　 本网站（www.baidu.com）所有的产品、技术与所有程序均属于知识产权，在此并未授权。
　　 “Baidu”, “”及相关图形等为的注册商标。
　　 未经许可，任何人不得擅自（包括但不限于：以非法的方式复制、传播、展示、镜像、上载、下载）使用。否则，将依法追究法律责任。

六、青少年用户特别提示

青少年用户必须遵守全国青少年网络文明公约：
要善于网上学习，不浏览不良信息；要诚实友好交流，不侮辱欺诈他人；要增强自护意识，不随意约会网友；要维护网络安全，不破坏网络秩序；要有益身心健康，不沉溺虚拟时空。
      </textarea>
    </label></td>
    <td bgcolor="#F7F7F7">&nbsp;</td>
  </tr>
</table>
<div class="copy_right"><%=ROYcms.Config.ROYcmsConfig.GetCmsConfigValue("web_name")%> 版权所有 ROYcms NT!技术支持</div>
</form>
<script type="text/javascript">
<!--
var sprypassword1 = new Spry.Widget.ValidationPassword("sprypassword1", {minChars:6});
var spryconfirm1 = new Spry.Widget.ValidationConfirm("spryconfirm1", "txtpassword");
var sprytextfield1 = new Spry.Widget.ValidationTextField("sprytextfield1", "none", {maxChars:18, minChars:2});
var sprytextfield2 = new Spry.Widget.ValidationTextField("sprytextfield2", "email");
var spryradio1 = new Spry.Widget.ValidationRadio("spryradio1");
//-->
</script>
</body>
</html>
