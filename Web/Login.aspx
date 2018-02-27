<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication6.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="keywords" content="Sign In Form Widget Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
		function hideURLbar(){ window.scrollTo(0,1); } </script>
    <script src="js/jquery-1.11.1.min.js"></script>
    <link href="css/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    	<div class="main">
		<h1>Sign In & Sign Up</h1>
		<div class="w3_login">
			<div class="w3_login_module">
				<div class="module form-module">
				  <div class="toggle"><i class="fa fa-times fa-pencil"></i>
					<div class="tooltip">Click Me</div>
				  </div>
                    <form id="form1" runat="server" action="#" method="post">
				  <div class="form">
					<h2>Login to your account</h2>
					
                        <asp:TextBox ID="UserName" runat="server" placeholder="用户名"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" ErrorMessage=""></asp:RequiredFieldValidator>
                        <asp:TextBox ID="Password" runat="server" placeholder="密码" TextMode="Password"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage=""></asp:RequiredFieldValidator>
                        <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />	<br />
                      <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>  
				  </div>				  				
					 </form>
                     <div class="cta"><a href="adminlogin.aspx">管理员登录</a> 
                         <a href="Register.aspx">立即注册</a>
                     </div>
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
			<p>© 2016 Sign In & Sign Up .江西师范大学 | Design by 3522有限公司 <a href="#">RUANKAO</a></p>
		</div>
	</div>
</body>
</html>
