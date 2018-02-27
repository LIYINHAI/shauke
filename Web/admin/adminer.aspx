<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminer.aspx.cs" Inherits="Web.admin.adminer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/admin_index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery.js"></script>

<script type="text/javascript">
    $(document).ready(function () {
        $(".div2").click(function () {
            $(this).next("div").slideToggle("slow").siblings(".div3:visible").slideUp("slow");
        });
    });
</script>

    <title>后台管理</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--顶部菜单信息--%>
        <div class="topbar ">
            <div class="white left" >
                <a href="../Index.aspx" class="bt_left white">首页</a></div>
            <div class="white right">
                <asp:LinkButton ID="LBtuichu" runat="server" ForeColor="White" 
                      CssClass="bt_right">退出</asp:LinkButton>                 
            </div>
        </div>
       <%-- 左侧菜单--%>
        <div class="leftquyu left">
            <di class="div1">
            <div></div>
            
                <div class="div2">
                    用户管理</div>
                <div class="div3">
                    <ul>
                        <li><a href="adminuser.aspx" target="mainframe">编辑用户</a></li>
                    </ul>
                </div>
            <div class="div2">
                    新闻管理</div>
            <div class="div3">
                    <ul>                
                    <li ><a href="addnews.aspx" target="mainframe">增加新闻</a></li>                    
                    <li><a href="adminnew.aspx" target="mainframe">编辑新闻</a></li>                     
                </ul>
            </div>
                 <div class="div2">
                    精品课程</div>
                <div class="div3">
                    <ul>
                        <li><a href="addcous.aspx" target="mainframe">增加课程</a></li>
                        <li><a href="admincou.aspx" target="mainframe">编辑课程</a></li>
                    </ul>
                </div>
                 <div class="div2">
                    评论管理</div>
                <div class="div3">
                    <ul>
                        <li><a href="adminpinlun.aspx" target="mainframe">编辑评论</a></li>
                    </ul>
                </div>
                 <div class="div2">
                    试卷管理</div>
                <div class="div3">
                    <ul>                       
                        <li><a href="addshijuan.aspx" target="mainframe">增加试卷</a></li>
                        <li><a href="adminshijuan.aspx" target="mainframe">试卷管理</a></li>
                    </ul>
                </div>
            </di v>
        </div>
        <%--右侧显示区域--%>
        <div class="rightquyu right">
        <iframe class="rightframe"  name="mainframe"></iframe>
         <div class="copyright"> &copy;2015 Powered by <a href="http://www.learning365.cn" target="_blank">learning365</a></div>
        </div>

    </div>
    </form>
</body>
</html>
