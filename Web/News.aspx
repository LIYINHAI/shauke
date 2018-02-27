<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="inner-page">
    <div class="top-center">
      <h2>新闻资讯</h2>
        <p>在这里你能了解到新的软考资讯，得到第一手消息！！！</p>
        </div>
        </div>
    <div style="clear: both; margin-bottom: 30px; overflow: hidden;">
        <div>
            <div>
                <asp:HyperLink ID="kcLink" runat="server" CssClass="ch" Text="新闻公告" NavigateUrl="#" Font-Names="微软雅黑" Font-Size="16" Font-Underline="false"></asp:HyperLink>
            </div>

            <div>
                <div style="float:right;">
                    <p>当前位置：新闻资讯</p>
                </div>
            </div>
        </div>

        <div>
            <asp:ListView ID="ListView1" runat="server">
                 <LayoutTemplate>
                    <div id="itemPlaceholderContainer" runat="server">
                        <div id="itemPlaceholder" runat="server">
                        </div>
                    </div>
                    <div style="width: 100%; float: left; background-color: #ececec;">
                        <asp:DataPager ID="DataPager1" class="myPager" runat="server" PageSize="8">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="true" ShowNextPageButton="false"
                                    ShowPreviousPageButton="true" FirstPageText="首页" NextPageText="下一页" PreviousPageText="上一页" LastPageText="尾页" />
                                <asp:NumericPagerField ButtonCount="5" CurrentPageLabelCssClass="current" />
                                <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True"
                                    ShowNextPageButton="true" NextPageText="下一页" PreviousPageText="上一页"  ShowPreviousPageButton="false" FirstPageText="首页" LastPageText="尾页" />

                            </Fields>

                        </asp:DataPager>

                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <br />
                    <div style="font-family: 'Microsoft YaHei'; border-bottom: 1px dashed #e3e3e5; padding: 5px; overflow: hidden;">
                        <div style="float: left; padding: 5px; width: 80%;">
                            <asp:HyperLink ID="HyperLink1" runat="server" Font-Names="微软雅黑" ToolTip='<%#"点击查看："+ Eval("NewsTitle") %>' Font-Size="12" NavigateUrl='<%#"~/NewsDetail.aspx?id="+Eval("NewsID") %>' ForeColor="#2b2b2b" Font-Underline="false" Text='<%#Eval("NewsTitle") %>' onmouseover="this.style.textDecoration='underline';this.style.color='steelblue';" onmouseout="this.style.textDecoration='none';this.style.color='#2b2b2b'"></asp:HyperLink>
                        </div>
                        <div style="float: right; padding: 5px; width: 12%;">
                            <asp:Label ID="Label1" runat="server" Font-Names="微软雅黑" Font-Size="10" Text='<%#String.Format("{0:yyyy-MM-dd hh:mm}",Eval("NewsTime")) %>' ForeColor="gray"></asp:Label>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>

        <asp:LinqDataSource ID="LinqDataSource1" runat="server">
        </asp:LinqDataSource>

    </div>
</asp:Content>
