<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="ShowPage.aspx.cs" Inherits="Web.ShowPage" %>
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
                        <li id="examindex" class="active"><a href="#" id="tdd">练习中心</a></li>
                        <li id="myrecord"><a href="#">我的考试</a></li>
                        <li id="myctb"><a href="cuoti.aspx">错题本</a></li>
                        <li id="myfavorite"><a href="#">我的收藏</a></li>
                    </ul>
                </div>
            </div>
            <div class="clear"></div>
            <div class="m-examHead f-bg">
                <!--试卷头信息-->
                <h1 class="h1">
                    <asp:Label ID="lblKaoJuanName" runat="server"></asp:Label>&nbsp;&nbsp;&nbsp;满分:<asp:Label ID="Label15" runat="server"></asp:Label>
                </h1>
            </div>
            <div id="NavFixHeight" style="clear:both;">
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                              ForeColor="#333333" GridLines="None" Width="100%" >
                              <RowStyle BackColor="#EFF3FB" />
                              <Columns>
                                  <asp:TemplateField>
                                      <HeaderTemplate>
                                          <asp:Label ID="Label24" runat="server" Text="选择题">
                                            </asp:Label>
                                      </HeaderTemplate>
                                      <ItemTemplate>
                                          <table id="Table2" align="center" border="0" cellpadding="1" cellspacing="1" style="width: 100%">
                                              <tr>
                                                  <td colspan="3">
                                                      <asp:Label ID="Label1" runat="server" Text='<%# Container.DataItemIndex+1 %>'>
									                </asp:Label>
                                                      <asp:Label ID="Label2" runat="server" Text='<%# Eval("Title","、{0}") %>'>
									                </asp:Label>
									                     <asp:Label ID="Label111" runat="server" Text='<%# Eval("ObID") %>' Visible="False" >
													                </asp:Label>
                                                      <asp:Label ID="Label3" runat="server" Text='<%# Eval("Answer") %>' Visible="False">
									                </asp:Label>
                                                      <asp:Label ID="Label4" runat="server" Text='<%# Eval("Mark") %>' Visible="false">
									                </asp:Label>
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td width="200">
                                                      <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Sl" Text='<%# Eval("AnswerA") %>' /></td>
                                                  <td width="200">
                                                      <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Sl" Text='<%# Eval("AnswerB") %>' /></td>
                                                  <td style="width: 50px">
                                                  </td>
                                              </tr>
                                              <tr>
                                                  <td width="35%">
                                                      <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Sl" Text='<%# Eval("AnswerC") %>' /></td>
                                                  <td width="35%">
                                                      <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Sl" Text='<%# Eval("AnswerD") %>' /></td>
                                                  <td style="width: 50px">
                                                  </td>
                                              </tr>
                                          </table>
                                      </ItemTemplate>
                                  </asp:TemplateField>
                              </Columns>
                              <FooterStyle BackColor="White" Font-Bold="True" ForeColor="White" />
                              <PagerStyle BackColor="Silver" ForeColor="White" HorizontalAlign="Center" />
                              <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                              <HeaderStyle BackColor="White" Font-Bold="True" Font-Size="12pt" ForeColor="White"
                                  HorizontalAlign="Left" />
                              <EditRowStyle BackColor="White" />
                              <AlternatingRowStyle BackColor="White" />
                          </asp:GridView>
                 <input id="Button1" runat="server" class="button" name="Submit" onserverclick="Button1_ServerClick1"
                              style="width: 90px" type="button" value="提交试卷" />
             </div>
        </div>
        </div>
</asp:Content>
