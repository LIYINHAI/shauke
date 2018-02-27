<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminpinlun.aspx.cs" Inherits="Web.admin.adminpinlun" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
         .top-title {
    
    margin-top: 20px; 
    background-color:#3C86C5; 
    padding:5px; border-radius:2px; 
    background-position:-88px 0pt; 
    color:#ffffff;
    width:100%;
    text-align:center;
}
         .table{
             margin-top:50px;
             width:90%;
             margin-left:auto;

         }
         .table .tr1 td{
             font-size:15px;
             font-family:'Microsoft YaHei';
         }
         .table .tr2 td{           
             font-size:15px;
         }
         .sxy{
             text-align:center;
             margin-top:35px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="top-title">
         <asp:Label ID="Label4" runat="server" Text="课程评论列表管理" Font-Size="15" Font-Names="微软雅黑"></asp:Label>
    </div>
        <table class="table" style="border-collapse:separate; border-spacing:0px 20px; ">
            <tr class="tr1">
                <td style="width:10%;">评论者</td>
                <td style="width:25%;">课程名称</td>
                <td style="width:20%;">时间</td>
                <td style="width:30%;">内容</td>
                <td style="width:15%;">操作</td>
            </tr>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>                                
            <tr class="tr2">
                 <td><asp:Label ID="name" runat="server" Text='<%#Eval("UserName") %>'></asp:Label></td>
                    <td><asp:Label ID="AssID" runat="server" Text='<%#Eval("ThemeName") %>'></asp:Label></td>
                    <td ><asp:Label ID="time" runat="server" Text='<%#Eval("ComTime") %>'></asp:Label></td>
                    <td ><asp:Label ID="content" runat="server" Text='<%# SplitChar(Eval("ComContent").ToString(),15)%>'></asp:Label></td>                  
                    <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("ComID")%>' />
                        <asp:Button ID="btnDelete" runat="server" Text="删除"  OnClick="btnDelete_Click"  OnClientClick="return confirm('确认删除？')"/>
                    </td>
            </tr>
              </ItemTemplate>
            </asp:ListView>
        </table>
         <div class="sxy">
                        共有<span id="totalRows" runat="server"></span>条   
 <span id="totalPage" runat="server"></span>
                        <asp:DataPager runat="server" PagedControlID="ListView1" PageSize="8" ID="DDPager">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                                <asp:NumericPagerField ButtonCount="4" />
                                <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                            </Fields>
                        </asp:DataPager>
                    </div>
    </div>
    </form>
</body>
</html>
