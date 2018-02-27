<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminshijuan.aspx.cs" Inherits="Web.admin.adminshijuan" %>

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
         <asp:Label ID="Label1" runat="server" Text="编辑试卷" Font-Size="15" Font-Names="微软雅黑"></asp:Label>
    </div>
           <table cellspacing="0" cellpadding="5" width="100%" border="0">
            <tr>
                <td class="manageHead">当前位置：试卷信息管理</td>
            </tr>
            <tr>
                <td align="center">试卷名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" /></td>
            </tr>
            <tr>
                <td align="left">
                    <asp:GridView ID="GvInfo" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        BackColor="White" CellPadding="5" DataKeyNames="KaoJuanID" OnPageIndexChanging="GvInfo_PageIndexChanging"
                        OnRowDataBound="GvInfo_RowDataBound" OnRowDeleting="GvInfo_RowDeleting" Width="100%">
                        <PagerSettings FirstPageText="首页" LastPageText="尾页" Mode="NextPreviousFirstLast"
                            NextPageText="下一页" PageButtonCount="12" PreviousPageText="上一页" />
                        <RowStyle HorizontalAlign="Left" />
                        <Columns>
                            <asp:TemplateField HeaderText="试卷名称">
                                <ItemTemplate>
                                    <asp:Label ID="KaoJuanName" runat="server" Text='<%# Bind("KaoJuanName") %>' Width="260px"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" Width="80px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="试卷科目">
                                <ItemTemplate>
                                    <asp:Label ID="CourseName" runat="server" Text='<%# Bind("CourseName") %>' Width="69px"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" Width="80px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="试卷分数">
                                <ItemTemplate>
                                    <asp:Label ID="PageFen" runat="server" Text='<%# Bind("PageFen") %>' Width="69px"></asp:Label>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Left" Width="80px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="删除" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                        Text="删除" Width="46px"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerTemplate>
                            <table border="0" width="100%">
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="LinkButtonFirstPage" runat="server" CommandArgument="First" CommandName="Page"
                                            Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != 0 %>">首页 </asp:LinkButton>
                                        <asp:LinkButton ID="LinkButtonPreviousPage" runat="server" CommandArgument="Prev"
                                            CommandName="Page" Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != 0 %>">上一页 </asp:LinkButton>
                                        <asp:LinkButton ID="LinkButtonNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                            Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>">下一页 </asp:LinkButton>
                                        <asp:LinkButton ID="LinkButtonLastPage" runat="server" CommandArgument="Last" CommandName="Page"
                                            Visible=" <%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>">尾页 </asp:LinkButton>
                                        共
                                  <asp:Label ID="LabelPageCount" runat="server" Text=" <%# ((GridView)Container.NamingContainer).PageCount %>"> </asp:Label>页
                                              第
                                  <asp:Label ID="Label2" runat="server" Text=" <%# ((GridView)Container.NamingContainer).PageIndex + 1 %>"> </asp:Label>页
                                    </td>
                                    <td align="right" width="20%"></td>
                                </tr>
                            </table>
                        </PagerTemplate>
                        <HeaderStyle BackColor="#F6F6F6" />
                    </asp:GridView>
                    &nbsp;<br />
                    <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>

