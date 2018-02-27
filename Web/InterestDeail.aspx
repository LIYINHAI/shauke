<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="InterestDeail.aspx.cs" Inherits="Web.InterestDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/InterestDeail.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="inner-page">
    <div class="top-center">
      <h2>兴趣小组</h2>
      <p class="lead">欢迎来到Software EDU！！！<br />本网站有展示有各种兴趣小组，大家可以在各种好玩有趣的兴趣小组里面找到自己的话题并加入</p>
    </div>                                 
   <div class="container">
    <div class="about-us">
      <div class="row">
          <asp:ListView ID="ListView1" runat="server">
             <LayoutTemplate>
                 <div>
                 <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                 </div>
             </LayoutTemplate>
              <ItemTemplate>
        <div class="col-md-4 col-sm-6">           
                 <div>
                     <img src="<%#Eval("Image") %>" class="img-responsive" alt="" />
                 </div>  
                 <div>
                     <h3>来加入我们吖！！！</h3>
                     <p>在激烈的小组讨论中畅游知识的海洋，获得成功，收获快乐！</p>
                 </div>             
             </div>
            
        <div class="col-md-4 col-sm-6">
          <h3>兴趣小组简介</h3>
          <p><%#Eval("ISBrief") %></p>
          <p>本小组创立时间悠久，在历史的长河之中屹立不倒，在各位It兴趣爱好者的共同努力下，本小组越来越活跃，让我们走上坚持创新探索未知的征程</p>
        </div>
        <div class="col-md-4 col-sm-6">
          <h3>时间表</h3>
          <p><strong><%#Eval("CreateTime") %></strong><br>
            在这一天我们小组诞生了，一伙志同道合的小伙伴们开创了一个本小组的历史</p>
          <p><strong>创立两年内</strong><br>
            在这两年内，我们开创了多个话题，各种形象有趣的话题，各种好玩的活动历历在目</p>
          <p><strong><%#Eval("CreateTime") %>-？</strong><br>
            未来的一切交给后来者，让你们谱写属于自己的篇章</p>
        </div>
                </ItemTemplate>
              </asp:ListView>
      </div>
    </div>
  </div>
         <%--兴趣话题--%>
  <section id="get-started"> 
      <asp:Panel ID="Panel3" runat="server">
      <asp:ScriptManager ID="ActScriptManager" runat="server" />
      <asp:UpdatePanel ID="ActUpdatePanel" runat="server">
                                        <ContentTemplate>    
  <div class="container">     
    <div class="row">
         
      <div class="col-sm-12">
      <h2>兴趣话题</h2>
      <hr/>
     </div>
        <asp:ListView ID="ListView2" runat="server"  GroupItemCount="3">
             <LayoutTemplate> 
                 <div>
                 <asp:PlaceHolder ID="groupPlaceHolder" runat="server"></asp:PlaceHolder>
                 </div>
             </LayoutTemplate>
             <GroupTemplate>
                 <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
             </GroupTemplate>
             <ItemTemplate>
        <div class="col-md-4 col-sm-6">
            <div class="recent-work-wrap">  
              <asp:Image ID="Image1" runat="server" CssClass="img-responsive" src='<%#Eval("ThemeImage") %>' />
            <div class="overlay">
              <div class="recent-work-inner">
                <h3><a href='ThemeDetails.aspx?id=<%#Eval("ThemeID") %>'target="_blank"><%#Eval("ThemeName") %></a> </h3>
                <p><%#Eval("Themecontent") %></p>
            </div>
            </div>
          </div>  
        </div>
                 </ItemTemplate>
        </asp:ListView>        
    </div>
  </div>  
       </ContentTemplate>
                                    </asp:UpdatePanel>
 </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
          <p  style="text-align:center;font-size:15px;font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">该小组暂无话题</p>
        </asp:Panel> 
</section>
         <%--新建话题--%>
         <div class="container">
             <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
             <div class="row">        
          <div class="col-sm-12">
          <h2 style="text-align:center">新建话题</h2>
          <hr />
          <div style=" margin-bottom: 15px;">
              <p>话题名</p>
              <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="请输入话题名"></asp:TextBox>
          </div>
          <%--<div style =" margin-bottom: 15px;">
              <p>建立时间</p>
              <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="请输入建立时间"></asp:TextBox>
          </div>--%>
          <div style =" margin-bottom: 15px;">
              <p>话题内容简介</p>
              <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" placeholder="请输入内容简介"></asp:TextBox>
          </div>
          <div>
              <p>上传</p>
              <div><asp:FileUpload ID="FileUpload" runat="server" ValidationGroup="shangchuan"/></div>
              <asp:Button ID="btnUpload" CssClass="btn btn-default" runat="server" Text="上传" OnClick="btnUpload_Click" ValidationGroup="shangchuan" /><br/>
              <asp:Label ID="Label1" runat="server" Text="" ForeColor="#008B00" Font-Bold="True"></asp:Label>
              路径：<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
          </div>  
          <div>
              <asp:Button ID="Button1" runat="server" Text="提交" CssClass="btn btn-default" OnClick="Button1_Click" />
          </div>        
          </div>
          </div>
          </ContentTemplate>
                 </asp:UpdatePanel>
         </div>
    </div>
     <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.isotope.min.js"></script>
    <script src="js/main.js"></script>
</asp:Content>
