<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="Examlist.aspx.cs" Inherits="Web.Examlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="css/exam.css" rel="stylesheet" />
    <link href="css/subfont.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="inner-page">
        <div class="container">
            <div class="practice clearfix bd-style">
                <div class="practice-r f-l">
                    <ul id="mynave">
                        <li id="examindex" class="active"><a href="practice.aspx" id="tdd">练习中心</a></li>
                        <li id="myrecord"><a href="MyExam.aspx">我的考试</a></li>
                        <li id="myctb"><a href="cuoti.aspx">错题本</a></li>
                        <li id="myfavorite"><a href="shoucang.aspx">我的收藏</a></li>
                    </ul>
                </div>
            </div>
            <div class="clear"></div>
            <div class="daily-time-box clearfix">
                <ul></ul>
            </div>
            <div class="content">

                <div style="float: left; width: 870px;">
                    <div id="content">
                        <div class="blank10 clear" id="reclear"></div>
                        <asp:ListView runat="server" ID="ListView1">
                            <LayoutTemplate>
                                <div id="itemPlaceHolder" runat="server"></div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div class="sjlist" id="xt151843">
                                    <div class="ex-text">
                                        <div class="xttitleclass">
                                            <strong>第<span class="xihao">
                                                <asp:Label ID="Label1" runat="server" Text='<%# Container.DataItemIndex+1 %>'>
                                                </asp:Label></span> 题：</strong>
                                        </div>
                                        <div class="xtcontentclass">
                                            <p>
                                                <asp:Label ID="LabelTitle" runat="server" Text='<%# Eval("Title","、{0}") %>'>
                                                </asp:Label>：<asp:Label ID="Label111" runat="server" Text='<%# Eval("ObID") %>' Visible="False">
                                                </asp:Label>（ &nbsp;&nbsp;）
                                            </p>
                                        </div>
                                        <div class="blank10 clear"></div>
                                        <div class="tacw"><strong>【您的答案】：</strong><asp:Label ID="LabelAns" runat="server" Text='<%# Eval("UserAns") %>'></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>【参考答案】：</strong></strong><asp:Label ID="Label3" runat="server" Text='<%# Eval("Answer") %>'></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
                                        <div class="ctleft"><strong>【收&nbsp;&nbsp;藏&nbsp;&nbsp;夹】：</strong><span class="frctb"> <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("ObID")%>' /><asp:Button ID="Button1" runat="server" Text="放入" OnClick="btnshou_Click" /></span></div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</asp:Content>
