<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="orderPage.aspx.cs" Inherits="ASCwebsite.WebForm8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="min-height: 100vh" class="container py-3">
        <div class="row">
            <div class="col-md-6 gap-2">
        <asp:Repeater ID="repeatProduct" runat="server">
            <ItemTemplate>

                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="images/iphone-13-roze-frontandback_3_600x600_BGresize_16777215-tj.png" class="card-img-top" alt="..." />
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title">
                                    <asp:Label ID="productName" runat="server" Text='<%# Eval("product_name") %>'></asp:Label></h5>
                                <h6 class="card-title">
                                    <asp:Label ID="productPrice" runat="server" Text='<%# Eval("total_pay") %>'></asp:Label></h6>
                                <p class="card-text">
                                    <asp:Label ID="address" runat="server" Text='<%# Eval("user_address") %>'></asp:Label>
                                </p>
                                <p class="card-text">
                                    <small class="text-muted">
                                        <asp:Label ID="landmark"  runat="server" Text='<%# Eval("landmark") %>'></asp:Label>
                                        <asp:Label ID="location"  runat="server" Text='<%# Eval("location") %>'></asp:Label>
                                        <asp:Label ID="city" runat="server" Text='<%# Eval("city") %>'></asp:Label>
                                        <asp:Label ID="state" runat="server" Text='<%# Eval("state") %>'></asp:Label>
                                        <asp:Label ID="pincode" runat="server" Text='<%# Eval("pincode") %>'></asp:Label>
                                    </small>
                                </p>
                                <a class="btn btn-warning my-2" href="orderPage.aspx?productName=<%# Eval("product_name") %>" style="text-decoration: none;">Cancel order</a>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
                </div>
     </div>
    </div>
</asp:Content>
