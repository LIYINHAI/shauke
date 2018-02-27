<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addshijuan.aspx.cs" Inherits="Web.admin.addshijuan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <title></title>
    <style type="text/css">
         .top-title {
    
    margin-top: 20px; 
    background-color:#3C86C5; 
    padding:5px; border-radius:2px; 
    background-position:-88px 0pt; 
    color:#ffffff;
    width:100%;
    text-align:center;
}
          .table{
             margin-top:50px;
             width:90%;
             margin-left:auto;

         }
         .table .tr1 td{
             font-size:15px;
             font-family:'Microsoft YaHei';
         }
         .table .tr2 td{           
             font-size:15px;
         }
         .sxy{
             text-align:center;
             margin-top:35px;
         }
         </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="top-title">
         <asp:Label ID="Label4" runat="server" Text="试卷管理" Font-Size="15" Font-Names="微软雅黑"></asp:Label>
    </div>
         <table align="center" border="0" cellpadding="0"
                        cellspacing="0" style="font-size: 12px; width: 100%; font-family: Tahoma; border-collapse: collapse">
              <tr style="color: #000000">
                  <td align="left" style="width: 97px; height: 35px">
                      选择科目：</td>
                  <td align="left" style="width: 294px; height: 35px">
                      <asp:DropDownList ID="ddlCourse" runat="server" Width="196px">
                      </asp:DropDownList></td>
              </tr>
              <tr style="color: #000000">
                  <td align="left" style="width: 97px; height: 35px">
                      试卷名称：</td>
                  <td align="left" style="width: 294px; height: 35px">
                      <asp:TextBox ID="TextBox4" runat="server" Width="361px"></asp:TextBox></td>
              </tr>
        
                        <tr style="color: #000000">
                            <td align="left" style="height: 35px; width: 97px;">
                                选择题数量：</td>
                            <td style="height: 35px; width: 294px;" align="left">
                                <asp:TextBox ID="TextBox1" runat="server" Width="80px"></asp:TextBox></td>
                        </tr>
            
             
            
             
              <tr style="color: #000000">
                  <td align="left" style="width: 97px; height: 34px">
                      试题总分：</td>
                  <td align="left" style="width: 294px; height: 34px">
                      <asp:TextBox ID="TextBox5" runat="server"  Width="80px"></asp:TextBox></td>
              </tr>
                        <tr align="center" height="55">
                            <td colspan="2">
                                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />
                                <asp:Button ID="Button2" runat="server" class="button" OnClick="Button2_Click" Text="生成试卷" /></td>
                        </tr>
              <tr align="center" height="55">
                  <td align="left" colspan="2">
                     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                          ForeColor="#333333" GridLines="None" Width="100%">
                          <RowStyle BackColor="#EFF3FB" />
                          <Columns>
                              <asp:TemplateField HeaderText="选择题">
                                  <ItemTemplate>
                                      <table id="Table2" align="center" border="0" cellpadding="1" cellspacing="1" width="100%">
                                          <tr>
                                              <td colspan="3">
                                                  <asp:Label ID="Label2" runat="server" Text='<%# Eval("Title","{0}") %>'>
													                </asp:Label>
                                                  <asp:Label ID="Label3" runat="server" Text='<%# Eval("ObID") %>' Visible="False">
													                </asp:Label>
                                                  本题分数：
                                                  <asp:Label ID="Label4" runat="server" Text='<%# Eval("Mark") %>'>
													                </asp:Label>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td width="35%">
                                                  <asp:RadioButton ID="RadioButton1" runat="server" Enabled="False" GroupName="Sl"
                                                      Text='<%# Eval("AnswerA") %>' /></td>
                                              <td width="35%">
                                                  <asp:RadioButton ID="RadioButton2" runat="server" Enabled="False" GroupName="Sl"
                                                      Text='<%# Eval("AnswerB") %>' /></td>
                                              <td>
                                              </td>
                                          </tr>
                                          <tr>
                                              <td width="35%">
                                                  <asp:RadioButton ID="RadioButton3" runat="server" Enabled="False" GroupName="Sl"
                                                      Text='<%# Eval("AnswerC") %>' /></td>
                                              <td width="35%">
                                                  <asp:RadioButton ID="RadioButton4" runat="server" Enabled="False" GroupName="Sl"
                                                      Text='<%# Eval("AnswerD") %>' /></td>
                                              <td>
                                              </td>
                                          </tr>
                                      </table>
                                  </ItemTemplate>
                              </asp:TemplateField>
                          </Columns>
                          <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                          <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                          <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                          <HeaderStyle BackColor="#507CD1" Font-Bold="True" Font-Size="12pt" ForeColor="White"
                              HorizontalAlign="Left" />
                          <EditRowStyle BackColor="#2461BF" />
                          <AlternatingRowStyle BackColor="White" />
                      </asp:GridView>
                      &nbsp;
                      &nbsp;&nbsp;
                      &nbsp;&nbsp;
                      </td>
              </tr>
              <tr align="center" height="55">
                  <td align="center" colspan="2" style="height: 31px">
                      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="保存试卷" /></td>
              </tr>
                    </table>
    </div>
    </form>
</body>
</html>
