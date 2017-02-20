<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master/Default.Master" CodeBehind="OrderList.aspx.vb" Inherits="BootCampApp.OrderList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadGrid ID="rgBookList" runat="server" AutoGenerateColumns="false">
        <MasterTableView>
            <Columns>
                <telerik:GridBoundColumn HeaderText="Customer Name" DataField="CustomerName" UniqueName="CustomerName">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn HeaderText="Customer Phone Number" DataField="PhoneNumber" UniqueName="PhoneNumber">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn HeaderText="Order Status" DataField="OrderStatus" UniqueName="OrderStatus"></telerik:GridBoundColumn>
                <telerik:GridTemplateColumn UniqueName="QuantityTotal">
                    <HeaderTemplate>
                        <table id="Table1" cellspacing="1" cellpadding="1" width="300" border="1">
                            <tr>
                                <td colspan="2" align="center">
                                    <b>Totals</b>
                                </td>
                            </tr>
                            <tr>
                                <td width="50%">
                                    <b>Quantity</b>
                                </td>
                                <td width="50%">
                                    <b>Amount</b>
                                </td>
                            </tr>
                      </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                      <table id="Table2" cellspacing="1" cellpadding="1" width="300" border="1">
                        <tr>
                          <td width="50%">
                            <asp:Label ID="lblQuantity" runat="server"></asp:Label>
                          </td>
                          <td width="50%">
                            <label id="lblAmount" runat="server">
                          </td>
                        </tr>
                      </table>
                    </ItemTemplate>
                  </telerik:GridTemplateColumn>
                
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
</asp:Content>
