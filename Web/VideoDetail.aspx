<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="VideoDetail.aspx.cs" Inherits="Web.VideoDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="inner-page">
    <div class="top-center">
      <h2>精品课程</h2>
      <p class="lead">欢迎来到Software EDU！！！<br />本页收入了各式各样的精品课程，按照级别分类各位可以尽情浏览</p>
    </div></div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
              </asp:ScriptManager>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
         <asp:ListView ID="ListView1" runat="server" GroupItemCount="1">
             <LayoutTemplate>
                 <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
             </LayoutTemplate>
              <ItemTemplate>
                  <div style="text-align:center;">
                      <video src='<%#Eval("VideoUrl") %>' controls="controls"/>                              
                  </div>
              </ItemTemplate>
         </asp:ListView>
                    </ContentTemplate>
         </asp:UpdatePanel>
    <div class="container">
        <%--留言板--%>                                              
                                <div class="comments" id="command">
                                    <asp:UpdatePanel ID="MessageUpdatePanel" runat="server">
                                        <ContentTemplate>
                                    <div class="first_main">
                                    <h4 class="widget-title" style="margin-bottom: 20px;">留言板</h4>
                                        <div class="Messagetext">
                                            <asp:TextBox ID="txtMessage" runat="server" class="form-control" placeholder="评论一番" TextMode="MultiLine"  ValidationGroup="txtMessage"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvtxtMessage" runat="server" ControlToValidate="txtMessage" SetFocusOnError="true" ErrorMessage="评论不能为空"  Display="Dynamic" ValidationGroup="txtMessage">评论不能为空</asp:RequiredFieldValidator>
                                        </div>
                                        <div class="btnMessage">
                                            <asp:Button ID="btnMessage" runat="server" class="btn btn-info" Text="发布留言"  OnClick="btnMessage_Click" ValidationGroup="txtMessage"/>
                                        </div>
                                    </div> 
                                      </ContentTemplate>
                            </asp:UpdatePanel>
                                   
                                    <asp:UpdatePanel ID="ReplyUpdatePanel" runat="server">
                                        <ContentTemplate>
                                            <asp:ListView ID="MessageListView" runat="server"  OnItemDataBound="lvComments_ItemDataBound">
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
                                            <%#Eval("LeaveContent") %> 
                                            </p>                                                                                  
                                        </div>
                                       <div><p style="text-align:right; float:right;"><%#Eval("LeaveTime") %></p></div>                                                                                                                       
                                    </span>
                                    <br />
                                    <div style="float:right;">
                                       <asp:LinkButton ID="lkbtnReply" runat="server" OnClick="lkbtnReply_Click" ValidationGroup="lkbtnReply">回复</asp:LinkButton></div>                                
                                    </div>
                                    <br />
                                    <asp:Panel ID="PanelReply" runat="server" Visible="false">
                                        <div class="reply_textbox">
                                            <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("LeaveID") %>' Visible="false" />
                                            <asp:TextBox ID="txtReplyContent" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                                            <asp:LinkButton ID="btnRply" runat="server" Text="发表" OnClick="btnRply_Click" class="btn btn-info" ValidationGroup="textReply" />
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
                                                    <%#Eval("ReplyLeaContent") %>
                                                    <div style="float:right;">
                                                    <%#Eval("ReplyLeaTime") %>
                                                    </div>
                                                </span>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </div>
                        </ItemTemplate>
                                               <%-- <LayoutTemplate>
                                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <div class="Message-content">
                                                        <div class="Messagearea">
                                                         <hr style="width: 100%; color: #dcd9d9; opacity: 0.5; margin-top: 20px;" />
                                                        <div class="Messager">
                                                            <span><a href="#"><%#Eval("UserName") %>:</a><p><%#Eval("LeaveContent") %></p></span><br />
                                                        </div>
                                                        <div class="Message-time">
                                                            <h8 style="color:#696666"><%#Eval("LeaveTime") %></h8>
                                                            <div class="lkbtnReply">
                                                            <asp:LinkButton ID="lkbtnReply" runat="server" OnClick="lkbtnReply_Click" ValidationGroup="lkbtnReply">回复</asp:LinkButton></div>
                                                        </div>
                                                        </div>
                                                        <asp:Panel ID="ReplyPanel" runat="server" Visible="false">
                                                              <div class="reply_textbox">
                                                                <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("LeaveID") %>' Visible="false" />
                                                                <asp:TextBox ID="txtReplyContent" class="form-control" TextMode="MultiLine" runat="server" ValidationGroup="textReply"></asp:TextBox><br />
                                                                 <asp:RequiredFieldValidator ID="rfvtxtReplyContent" runat="server" ControlToValidate="txtReplyContent" SetFocusOnError="true"  Display="Dynamic" ValidationGroup="textReply">回复不能为空</asp:RequiredFieldValidator>
                                                                <asp:LinkButton ID="btnRply" runat="server" Text="发表" OnClick="btnRply_Click" class="btn btn-info" ValidationGroup="textReply" />
                                                               </div>
                                                        </asp:Panel>
                                                    </div>
                                                     <asp:Repeater ID="ReplyRepeater" runat="server">
                                                        <ItemTemplate>
                                                            <hr />
                                                            <div class="Replytext">
                                                                <div class="Replyer">
                                                                <span><a href="#"><%#Eval("回复人") %>&nbsp 回复 &nbsp</a><a href="#"><%#Eval("被回复人") %>:</a><i><%#Eval("ReplyLeaContent") %></i></span></div>
                                                                <div class="ReplyTime">
                                                                    <h8 style="color:#696666"><%#Eval("ReplyLeaTime") %></h8>
                                                                </div>
                                                            </div>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </ItemTemplate>--%>
                                            </asp:ListView>
                                             
                                             <div class="Pager">
                        <!--分页信息*/-->
                        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="MessageListView" PageSize="5" OnPreRender="DataPager1_PreRender">
                            <Fields>
                                <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页"  ShowFirstPageButton="true" ShowNextPageButton="false" />
                                <asp:NumericPagerField  ButtonCount="4" />
                                <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false"  ShowLastPageButton="true" />
                            </Fields>
                        </asp:DataPager>
                    </div>
                                </ContentTemplate>
                                    </asp:UpdatePanel>       
                            </div>

                                <hr />
                                <%-- 留言板结束--%>
    </div>
         
       <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.isotope.min.js"></script>
    <script src="js/main.js"></script>
</asp:Content>
