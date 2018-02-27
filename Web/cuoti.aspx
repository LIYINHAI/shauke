<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="cuoti.aspx.cs" Inherits="Web.cuoti" %>
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
                        <li id="examindex"><a href="practice.aspx" id="tdd">练习中心</a></li>
                        <li id="myrecord"><a href="MyExam.aspx">我的考试</a></li>
                        <li id="myctb" class="active"><a href="#">错题本</a></li>
                        <li id="myfavorite"><a href="shoucang.aspx">我的收藏</a></li>
                    </ul>
                </div>
            </div>
            <div class="clear"></div>
            <div class="ex-text-list">
                <ul>
                    <asp:ListView runat="server" ID="ListView1">
                        <LayoutTemplate>
                            <div id="itemPlaceHolder" runat="server"></div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li>
                                <div class="blank10 clear" id="reclear"></div>
                                <div class="sjlist" id="xt151882">
                                    <div class="ex-text">
                                        <input type="hidden" name="tmid" id="tmid0" value="151882">
                                        <div class="xttitleclass">
                                            <strong>题目：</strong>
                                        </div>
                                        <div class="xtcontentclass">
                                            <p>
                                                <asp:Label ID="LabelTitle" runat="server" Text='<%# Eval("Title") %>'>
                                                </asp:Label>：<asp:Label ID="Label111" runat="server" Text='<%# Eval("ObID") %>' Visible="False">
                                                </asp:Label>（ &nbsp;&nbsp;）
                                            </p>
                                        </div>
                                        <div class="blank10 clear"></div>
                                        <div id="t151882" class="ta">
                                            <div class="ex-text-option ex-option-radio">
                                                <p>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("AnswerA") %>'>
                                                    </asp:Label>
                                                </p>
                                                <p>
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("AnswerB") %>'>
                                                    </asp:Label>
                                                </p>
                                                <p>
                                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("AnswerC") %>'>
                                                    </asp:Label>
                                                </p>
                                                <p>
                                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("AnswerD") %>'>
                                                    </asp:Label>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:ListView>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
