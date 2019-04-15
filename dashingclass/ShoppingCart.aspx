<%@ Page Title="My Shopping Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="dashingclass.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div id="ShoppingCartTitle" runat="server" class="ContentHead">
            <h1>Shopping Cart</h1>
        </div>
        <asp:GridView ID="CartList" runat="server"
            AutoGenerateColumns="False" ShowFooter="True"
            GridLines="Vertical" CellPadding="4"
            ItemType="dashingclass.Models.CartItem"
            SelectMethod="GetShoppingCartItems"
            CssClass="table table-striped table-bordered">
            <Columns>
                <asp:BoundField DataField="ProductId" HeaderText="ID" SortExpression="ProductId" />
                <asp:BoundField DataField="Product.ProductBrand" HeaderText="Brand" />
                <asp:BoundField DataField="Product.ProductSize" HeaderText="Size" />
                <asp:BoundField DataField="Product.ProductColor" HeaderText="Color" />
                <asp:BoundField DataField="Product.ProductName" HeaderText="Name" />
                <asp:BoundField DataField="Product.ProductCost" HeaderText="Unit Cost" />
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Item Total">
                    <ItemTemplate>
                        <%#: String.Format("{0:c}", ((Convert.ToDouble(Item.Quantity)) *  Convert.ToDouble(Item.Product.ProductCost)))%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remove Item">
                    <ItemTemplate>
                        <asp:CheckBox ID="Remove" runat="server"></asp:CheckBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div>
            <p></p>
            <strong>
                <asp:Label ID="TotalInformationLabel" runat="server" Text="Order Total: "></asp:Label>
                <asp:Label ID="TotalLabel" runat="server" EnableViewState="false"></asp:Label>
            </strong>
        </div>
        <br />
        <table>
            <tr>
                <td>
                    <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
                </td>
                <td>
                    <!--Checkout Placeholder -->
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
