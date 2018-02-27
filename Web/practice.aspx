<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="practice.aspx.cs" Inherits="Web.practice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/exam.css" rel="stylesheet" />
    <link href="css/subfont.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="inner-page">
        <div class="top-center">
            <h2>练习中心</h2>
            <p class="lead">
                欢迎来到练习中心！！！<br />
                这里有不同类别的试卷供你挑选，是你冲刺软考的最佳选择方案，坚不可摧的无纸化考试平台。
            </p>
        </div>
        <div class="container">
            <div class="practice clearfix bd-style">
                <div class="practice-r f-l">
                    <ul id="mynave">
                        <li id="examindex" class="active"><a href="#" id="tdd">练习中心</a></li>
                        <li id="myrecord"><a href="MyExam.aspx">我的考试</a></li>
                        <li id="myctb"><a href="cuoti.aspx">错题本</a></li>
                        <li id="myfavorite"><a href="shoucang.aspx">我的收藏</a></li>
                    </ul>
                </div>

            </div>
            <div class="clear"></div>
            <div class="exam_lmlist bd-style">
                <ul>
                    <asp:ListView runat="server" ID="ListView1">
                        <LayoutTemplate>
                            <div id="itemPlaceHolder" runat="server"></div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li>
                                <div class="btn" onclick="window.open('<%# "ShowPage.aspx?id="+Eval("KaoJuanID") %>')"><i class="iconfont icon-zhuantilianxi"></i>进入考试</div>
                                <div class="litit"><span>[<%#Eval("CourseName") %>]</span><a href='<%# "ShowPage.aspx?id="+Eval("KaoJuanID") %>'><span><%#Eval("KaoJuanName") %></span></a></div>
                                <div class="liinfo"><span>时间：120分钟</span><span>总分：<%#Eval("PageFen") %> 分</span><span><img src="Image/img1/start.png" /></span></div>
                            </li>
                        </ItemTemplate>
                    </asp:ListView>
                </ul>
            </div>
   
        </div>
    </div>
</asp:Content>
