<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="ASCwebsite.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content1body ">
        <div class="text-center my-3 row-cols-4">
            <asp:Button ID="ElectronicsButton" class="btn btn-primary col col-md-1" runat="server" Text="Electronics" OnClick="ElectronicsButton_Click" />
            <asp:Button ID="GroceryButton" class="btn btn-primary col  col-md-1" runat="server" Text="Grocery" OnClick="GroceryButton_Click" />
            <asp:Button ID="AppliancesButton" class="btn btn-primary col  col-md-1" runat="server" Text="Appliances" OnClick="AppliancesButton_Click" />
        </div>
        <div>
            <div id="carouselExampleIndicators" class="carousel slide">
                <div class="carousel-indicators">
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
                </div>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="images/flipkart-big-billion-days-1601723944%20(1).jpg" class="d-block w-100" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <img src="images/Flipkart_Big_Billion_Days__1200x600.png" class="d-block w-100" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <img src="images/Flipkart-Big-billion-days-2021-featured-image-1%20(1).png" class="d-block w-100" alt="..." />
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
        <div >
            <div class="my-2">
                <h4 class="my-2 mx-3 py-2">Deal for you</h4>
                <div >

                <div class="row row-cols-1 row-cols-sm-3  row-cols-md-5 my-3 mx-2   gap-3 px-3  text-justify">
                    <asp:Repeater ID="repeatProduct" runat="server">
                        <ItemTemplate>
                            <a href="productDetailsPage.aspx?productId=<%# Eval("product_id") %>" style="text-decoration:none;">

                            <div class="card col shadow productCard"  >
                                <img src="images/iphone-13-roze-frontandback_3_600x600_BGresize_16777215-tj.png" class="card-img-top" alt="..." />
                                <div class="card-body">
                                    <h4 class="text-center">
                                        <asp:Label ID="productName" runat="server" Text='<%# Eval("product_name") %>'></asp:Label>
                                    </h4>
                                    <h4 class="text-center">
                                         &#8377 <asp:Label ID="productPrice" runat="server" Text='<%# Eval("product_price") %>'></asp:Label>
                                    </h4>
                                </div>
                            </div>  
                            </a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
