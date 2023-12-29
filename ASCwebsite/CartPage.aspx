<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="ASCwebsite.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="min-height: 100vh;">
        <div class="row row-cols-1 row-cols-sm-3  row-cols-md-5 my-3 mx-2   gap-3 px-3  text-justify">

            <asp:Repeater ID="repeatProduct" runat="server" >
                <ItemTemplate>
                    <div class="card col shadow productCard">
                        <img src="images/iphone-13-roze-frontandback_3_600x600_BGresize_16777215-tj.png" class="card-img-top" alt="..." />
                        <div class="card-body">
                            <h4 class="text-center">
                                <asp:Label ID="productName" runat="server" Text='<%# Eval("product_name") %>'></asp:Label>
                            </h4>
                           
                            <div class="row">

                                <a class="btn btn-danger " href="CartPage.aspx?cartProductId=<%# Eval("product_id") %>" style="text-decoration: none;">Remove </a>
                                <a class="btn btn-warning my-2" href="productDetailsPage.aspx?productId=<%# Eval("product_id") %>" style="text-decoration: none;">Buy Now </a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
                                
                                

        </div>
    </div>
</asp:Content>
