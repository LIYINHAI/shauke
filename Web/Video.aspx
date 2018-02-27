<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="Video.aspx.cs" Inherits="Web.Video" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="inner-page">
    <div class="top-center">
      <h2>精品课程</h2>
      <p class="lead">欢迎来到维尔网！！！<br />本页收入了各式各样的精品课程，按照级别分类各位可以尽情浏览</p>
    </div>
      <div class="container">
          <asp:ScriptManager ID="ScriptManager1" runat="server">
              </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
    <ul class="portfolio-filter text-center">
      <li><asp:Button ID="quanbu" runat="server" Text="全部" CssClass="btn btn-default active" OnClick="quanbu_Click"/></li>
      <li><asp:Button ID="Button1" runat="server" Text="初级" CssClass="btn btn-default" OnClick="Button1_Click"/></li>
      <li><asp:Button ID="Button2" runat="server" Text="中级"  CssClass ="btn btn-default" OnClick="Button2_Click"/></li>
      <li><asp:Button ID="Button3" runat="server" Text="高级"  CssClass ="btn btn-default" OnClick="Button3_Click"/></li>
    </ul>
    <!--/#portfolio-filter-->
                    <div class="row"><div class="portfolio-items"> 
          <asp:ListView ID="ListView1" runat="server">
        <LayoutTemplate>
            
                 <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
           
        </LayoutTemplate>
        <ItemTemplate>
        
        <div class="portfolio-item apps col-xs-12 col-sm-4 col-md-4">

          <div class="recent-work-wrap">  
              <asp:Image ID="Image1" runat="server" CssClass="img-responsive" src='<%#Eval("Images") %>' />
            <div class="overlay">
              <div class="recent-work-inner">
                <h3><a href='VideoDetail.aspx?id=<%#Eval("VideoID") %>'target="_blank"><%#Eval("VideoName") %></a> </h3>
                <p><%#Eval("VideoBrief") %></p>
                <a class="preview" href='VideoDetail.aspx?id=<%#Eval("VideoID") %>' >观看</a> </div>
            </div>
          </div>
        
      </div>
            </ItemTemplate>
    </asp:ListView>
                        </div></div>
                   
          <section id="get-started">
  <div class="container">
    <div class="row">
      <div class="col-sm-12">共有<span id="totalRows" runat="server"></span>条   
 <span id="totalPage" runat="server"></span>
        <h2><asp:DataPager runat="server" PagedControlID="ListView1" PageSize="9" ID="DDPager">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                                <asp:NumericPagerField ButtonCount="4" />
                                <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                            </Fields>
                        </asp:DataPager>

        </h2>
     </div>
    </div>
  </div>
  <!--/.container--> 
</section>
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
