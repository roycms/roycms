<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Md5.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.App_Api.Md5" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="/Administrator/Bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css">
<link href="/Administrator/Bootstrap/css/bootstrap-responsive.css" rel="stylesheet" type="text/css">
<script src="/Administrator/Bootstrap/jquery.min.js" ></script>
<script src="/Administrator/Bootstrap/bootstrap.js"></script>
<script src="/Administrator/js/formValidatorRegex.js"></script>
<script src="/Administrator/js/Login.js"></script>
<title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div class="container-fluid">
	<div class="row-fluid">
		<div class="span12">
			<div class="page-header">
				<h1>
					字符串加密 <small>CMS系统字符串加密方法API</small>
				</h1>

                  <div class="control-group">
                  <label class="control-label" for="inputEmail">要加密的字符串</label>
                  <div class="controls">
                       <asp:TextBox ID="MD5Text" runat="server" Width="480px"></asp:TextBox>
                      
                  </div>
                  </div>

                  <div class="control-group">
                  <label class="control-label" for="inputEmail">加密后字符串</label>
                  <div class="controls">
                     <asp:TextBox ID="TextBox_fuzhi" runat="server" Width="480px"></asp:TextBox> 
                  </div>
                  </div>

               
        
              
			</div>
            <asp:Button ID="MD5Button" runat="server" Text="获取加密后的字符串" CssClass="btn btn-primary" onclick="MD5Button_Click" />
		</div>
	</div>
</div>



   

    </form>
   
</body>
</html>
