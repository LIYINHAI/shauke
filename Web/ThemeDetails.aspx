 <%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="ThemeDetails.aspx.cs" Inherits="Web.ThemeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/InterestDeail.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="inner-page">
  <div class="top-center">
     <asp:ListView ID="ListView1" runat="server">
             <LayoutTemplate>
                 <div>
                 <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                 </div>
             </LayoutTemplate>
              <ItemTemplate>
                 <div>
                     <h2><%#Eval("ThemeName") %></h2>
                     <p><%#Eval("ThemeContent") %></p>
                 </div>
              </ItemTemplate>
         </asp:ListView>
      </div>
        </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
              </asp:ScriptManager>
    <div class="comments">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div>
                        <asp:TextBox ID="txtComments" CssClass="form-control" runat="server" TextMode="MultiLine" placeholder="说点什么吧..."></asp:TextBox>
                    </div>
                    <div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" Font-Bold="true" Font-Size="16px" runat="server" ErrorMessage="评论内容不能为空" Display="Static" ControlToValidate="txtComments" ValidationGroup="comments"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="16px" ErrorMessage="字数不能超过140字" Display="Dynamic" ControlToValidate="txtComments" ValidationExpression="^[\s\S]{1,140}$" ValidationGroup="comments"></asp:RegularExpressionValidator>
                    </div>
                    <div style ="float:right">
                    <asp:Button ID="btnComments" CssClass="btn btn-default" runat="server" Text="评论" OnClick="btnComments_Click" ValidationGroup="comments" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr style="width: 100%; color: #dcd9d9;"/>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:ListView ID="lvComments" runat="server" OnItemDataBound="lvComments_ItemDataBound">
                        <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="comment_content">
                                <div style="border-top: 1px solid #dcd9d9; border-bottom: 1px solid #dcd9d9;">
                                    <div>
                                       <li><%#Eval("UserName")%></li>
                                    </div>                                  
                                    <br />                                 
                                    <span>
                                        <div><p>
                                            <a href="#">
                                                <%#Eval("UserName") %>：
                                            </a>
                                            <%#Eval("ComContent") %> 
                                            </p>                                                                                  
                                        </div>
                                       <div><p style="text-align:right; float:right;"><%#Eval("ComTime") %></p></div>                                                                                                                       
                                    </span>
                                    <br />
                                    <div style="float:right;">
                                        <asp:LinkButton ID="lbtnReply" runat="server" OnClick="lbtnReply_Click">回复</asp:LinkButton>                                       
                                    </div>
                                    <br />
                                    <asp:Panel ID="PanelReply" runat="server" Visible="false">
                                        <div class="reply_textbox">
                                            <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("ComID") %>' Visible="false" />
                                            <asp:TextBox ID="txtReplyContent" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                                            <asp:Button ID="btnRply" runat="server" Text="发表" OnClick="btnRply_Click" CssClass="btn btn-default" ValidationGroup="reply_comments" />
                                        </div>
                                        <div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" Font-Bold="true" Font-Size="14px" runat="server" ErrorMessage="回复内容不能为空" Display="Dynamic" ControlToValidate="txtReplyContent" ValidationGroup="reply_comments"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" Font-Bold="true" Font-Size="14px" ErrorMessage="字数不能超过140字" Display="Dynamic" ControlToValidate="txtReplyContent" ValidationExpression="^[\s\S]{1,140}$" ValidationGroup="reply_comments"></asp:RegularExpressionValidator>
                                        </div>

                                    </asp:Panel>

                                </div>

                                <asp:Repeater ID="RepeaterReplyComments" runat="server">
                                    <ItemTemplate>
                                        <div class="reply">
                                            <div class="reply_contents">
                                                <span>
                                                    <a href="#">
                                                        <%#Eval("回复人")%>
                                                    </a>
                                                    回复
                                                    <a href="#">
                                                        <%#Eval("被回复人")%>
                                                    </a>：
                                                    <%#Eval("ReplyComContent") %>
                                                    <div style="float:right;">
                                                    <%#Eval("ReplyComTime") %>
                                                    </div>
                                                </span>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                    </ContentTemplate>
            </asp:UpdatePanel>
                    </div>
    <%-- <asp:UpdatePanel ID="MessageUpdatePanel" runat="server">
                                        <ContentTemplate>
         <div class="container">
             <div>
                  <asp:TextBox ID="txtMessage" runat="server" class="form-control" placeholder="说说感觉" TextMode="MultiLine"  ValidationGroup="txtMessage"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rfvtxtMessage" runat="server" ControlToValidate="txtMessage" SetFocusOnError="true" ErrorMessage="评论不能为空"  Display="Dynamic" ValidationGroup="txtMessage">评论不能为空</asp:RequiredFieldValidator>
             </div>             
         <div style="text-align:center">
             <asp:Button ID="btnMessage" runat="server" class="btn btn-default" Text="发表评论"  OnClick="btnMessage_Click" ValidationGroup="txtMessage"/>
         </div>
         </div>         
     </ContentTemplate>
         </asp:UpdatePanel>--%>
</asp:Content>
