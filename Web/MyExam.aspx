<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="MyExam.aspx.cs" Inherits="Web.MyExam" %>

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
                        <li id="myfavorite"><a href="shoucang.aspx">我的收藏</a></li>
                    </ul>
                </div>
            </div>
            <div class="clear"></div>
            <table width="100%" cellpadding="0" cellspacing="0" class="ex-record bd-style">
                <tbody>
                    <tr class="ex-record-head">
                        <td class="ex-record-id">序号</td>
                        <td class="ex-record-title">试卷名称</td>
                        <td class="ex-record-type">答对个数</td>
                        <td class="ex-record-score">得分</td>
                        <td class="ex-record-operate">操作</td>
                        
                    </tr>
                    <asp:ListView runat="server" ID="ListView1">
                        <LayoutTemplate>
                            <div id="itemPlaceHolder" runat="server"></div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td class="ex-record-id">
                                    <asp:Label ID="Label1" runat="server" Text='<%# Container.DataItemIndex+1 %>'>
                                    </asp:Label></td>
                                <td class="ex-record-title">
                                    <asp:Label ID="Label3" runat="server"><%# Eval("KaoJuanName") %></asp:Label></td>
                                <td class="ex-record-type"> 
                                    <asp:Label ID="Label2" runat="server"><%# Eval("Sum") %></asp:Label></td>
                                <td class="ex-record-score">
                                    <asp:Label ID="addScore" runat="server"><%# Eval("Scores")%></asp:Label></td>
                                <td class="ex-record-operate"><a href='<%# "Examlist.aspx?id="+Eval("KaoJuanID") %>'>查看解析</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </tbody>
            </table>
    
        </div>
    </div>
</asp:Content>
