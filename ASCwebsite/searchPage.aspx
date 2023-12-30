<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="searchPage.aspx.cs" Inherits="ASCwebsite.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="min-height: 100vh;">
        <center>
        <asp:Label CssClass="py-3 " ID="SearchError" runat="server" Text=""></asp:Label>
        </center>
        <div class="row row-cols-1 row-cols-sm-3  row-cols-md-5 my-3 mx-2   gap-3 px-3  text-justify">
            <asp:Repeater ID="repeatProduct" runat="server">
                <ItemTemplate>
                    <a href="productDetailsPage.aspx?productId=<%# Eval("product_id") %>" style="text-decoration: none;">

                        <div class="card col shadow productCard">
                            <img src="images/iphone-13-roze-frontandback_3_600x600_BGresize_16777215-tj.png" class="card-img-top" alt="..." />
                            <div class="card-body">
                                <h4 class="text-center">
                                    <asp:Label ID="productName" runat="server" Text='<%# Eval("product_name") %>'></asp:Label>
                                </h4>
                                <h4 class="text-center">&#8377
                                    <asp:Label ID="productPrice" runat="server" Text='<%# Eval("product_price") %>'></asp:Label>
                                </h4>
                            </div>
                        </div>
                    </a>
                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
</asp:Content>
