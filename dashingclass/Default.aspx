<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="dashingclass._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:ListView ID="ProductList" runat="server"
            SelectMethod="GetProducts"
            ItemType="dashingclass.Models.Product"
            GroupItemCount="4"
            DataKeyNames="ProductId">
            <EmptyDataTemplate>
                <div class="card-deck">
                    <div class="card">
                        <div class="card-title">No Items</div>
                    </div>
                </div>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <div />
            </EmptyItemTemplate>
            <GroupTemplate>
                <div id="itemPlaceholderContainer" class="card-deck" runat="server">
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                </div>
            </GroupTemplate>
            <ItemTemplate>
                <div class="card bg-dark text-white mb-4">
                    <a href="ProductDetails.aspx?productID=<%#:Item.ProductId%>">
                        <img src="/Catalog/Images/<%#:Item.ImagePath%>" class="card-img-top img-thumbnail" />
                        <div class="card-header">
                            <h5 class="card-title">
                                <%#:Item.ProductBrand %>&nbsp;<%#:Item.ProductSize %>&nbsp;<%#:Item.ProductColor %>&nbsp;<%#:Item.ProductName %>
                            </h5>
                            <div class="card-text"><%#: Item.ProductCost %></div>
                        </div>
                    </a>
                    <div class="card-body">
                        
                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductId %>" class="btn btn-primary">
                            Add To Cart                              
                        </a>
                    </div>
                </div>

            </ItemTemplate>
            <LayoutTemplate>
                <div id="groupPlaceholderContainer" runat="server">
                    <div id="groupPlaceholder" runat="server">
                    </div>
                </div>
            </LayoutTemplate>
        </asp:ListView>
    </div>

</asp:Content>
