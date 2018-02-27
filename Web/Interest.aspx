<%@ Page Title="" Language="C#" MasterPageFile="~/web.Master" AutoEventWireup="true" CodeBehind="Interest.aspx.cs" Inherits="Web.Interest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="inner-page">
    <div class="top-center">
      <h2>兴趣小组</h2>
      <p class="lead">欢迎来到维尔网！<br />本网站有展示有各种兴趣小组，大家可以在各种好玩有趣的兴趣小组里面找到自己的话题并加入</p>
    </div>
          <div class="container">
    <div class="row">
         <asp:ListView ID="ListView1" runat="server">
        <LayoutTemplate>
            
                 <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
           
        </LayoutTemplate>
             <ItemTemplate>
        <div class="col-md-4 col-sm-6">          
         <asp:Image ID="Image1" runat="server" src='<%#Eval("Image") %>' />
            <h2><a href='InterestDeail.aspx?id=<%#Eval("ISID") %>' target="_blank"><%#Eval("ISName") %></a></h2>
            <h3><%#Eval("ISBrief") %></h3>
        </div>
                 </ItemTemplate>
             </asp:ListView>

          </div>
              <section id="get-started">
  <div class="container">
    <div class="row">
        <h2><asp:DataPager runat="server" PagedControlID="ListView1" PageSize="6" ID="DDPager">
                            <Fields>
                                <asp:NextPreviousPagerField ShowFirstPageButton="true" FirstPageText="首页" PreviousPageText="上一页" ShowNextPageButton="false" />
                                <asp:NumericPagerField ButtonCount="4" />
                                <asp:NextPreviousPagerField ShowPreviousPageButton="false" LastPageText="最后一页" NextPageText="下一页" ShowNextPageButton="true" ShowLastPageButton="true" />
                            </Fields>
                        </asp:DataPager>

        </h2>
     </div>
    </div>
</section>
        
      </div>
         </div>
    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.prettyPhoto.js"></script>
    <script src="js/jquery.isotope.min.js"></script>
    <script src="js/main.js"></script>
</asp:Content>
