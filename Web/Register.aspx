<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication6.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="keywords" content="Sign In Form Widget Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
    <script src="js/jquery-1.11.1.min.js"></script>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    	<div class="main">
		<h1>Register In</h1>
		<div class="w3_login">
			<div class="w3_login_module">
				<div class="module form-module">
				  <div class="toggle"><i class="fa fa-times fa-pencil"></i>
					<div class="tooltip">Click Me</div>
				  </div>
                    <form id="form1" runat="server" action="#" method="post">
				  <div class="form">
					<h2>Register a account</h2>					
                      <asp:TextBox ID="UserName" runat="server" placeholder="用户名"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="Password" runat="server" placeholder="密码" TextMode="Password"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="RePassword" runat="server" placeholder="确认密码" TextMode="Password"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="RePassword" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="Email" runat="server" placeholder="邮箱"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Email" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:TextBox ID="Phone" runat="server" placeholder="电话"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Phone" ErrorMessage=""></asp:RequiredFieldValidator>
                      <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" />
					
				  </div>				  
					
					 </form>  
                     <div class="cta"><a href="#">已有账号?</a><a href="Login.aspx">立即登录</a></div>
				  </div>
				 
				</div>
           
			<script>
				$('.toggle').click(function(){
				  // Switches the Icon
				  $(this).children('i').toggleClass('fa-pencil');
				  // Switches the forms  
				  $('.form').animate({
					height: "toggle",
					'padding-top': 'toggle',
					'padding-bottom': 'toggle',
					opacity: "toggle"
				  }, "slow");
				});
			</script>
		</div>
		<div class="agileits_copyright">
			<p>© 2017 Register In. 江西师范大学 | Design by 3522有限公司<a href="#">RUANKAO</a></p>
		</div>
	</div>
</body>
</html>
