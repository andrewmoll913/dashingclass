<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="dashingclass.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="ProductDetailsView" runat="server" ItemType="dashingclass.Models.Product" SelectMethod="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div class="row">
                <div class="col">
                    <img src="/Catalog/Images/<%#:Item.ImagePath%>" class="card-img-top" />
                </div>
                <div class="col">
                    <h1><%#:Item.ProductBrand %>&nbsp;<%#:Item.ProductSize %>&nbsp;<%#:Item.ProductName %></h1>
                    <p>Cost: <strong>NZD<%#:Item.ProductCost %></strong></p>
                    <p>Description: <%#:Item.Description %></p>
                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductId %>" class="btn btn-primary">Add To Cart                           
                    </a>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>