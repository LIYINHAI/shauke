<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="ExamResult.aspx.cs" Inherits="Web.ExamResult" %>

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
                        <li id="myrecord"><a href="#">我的考试</a></li>
                        <li id="myctb"><a href="cuoti.aspx">错题本</a></li>
                        <li id="myfavorite"><a href="#">我的收藏</a></li>
                    </ul>
                </div>
            </div>
            <div class="clear"></div>
            <div class="result">
                <div class="result-l">
                    <div class="result-title">考试结果</div>
                    <div class="result-content clearfix">
                        <div class="rc-l f-l">
                            <h4>
                                <asp:Label ID="lblKaoJuanName" runat="server"><%# Eval("KaoJuanName") %></asp:Label></h4>
                            <p>恭喜您完成了所有的题目，这次考试</p>
                            <p><asp:Label ID="lblUserName" runat="server"><%# Eval("UserName")%></asp:Label></p>
                            <p>您一共答对<asp:Label ID="lblsum" runat="server" Text="Label"></asp:Label>道</p>
                            <p>得分：<asp:Label ID="addScore" runat="server"><%# Eval("Score")%></asp:Label></p>
                            <p>交卷时间：<asp:Label ID="lbltime" runat="server" Text="Label"></asp:Label></p>
                        </div>
                        <div class="rc-r f-r">
                            <div id="indicatorContainer">
                                <canvas width="112" height="112"></canvas>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="exam-rightArea">
                    <div class="result-operate bd-style">
                        <div class="result-title">操作</div>
                        <ul>
                            <li><a href="DaAnList.aspx">查看解析</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
