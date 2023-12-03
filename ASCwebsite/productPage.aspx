<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="productPage.aspx.cs" Inherits="ASCwebsite.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div >
        <asp:Repeater ID="productDetails" runat="server">
        <ItemTemplate>
        <div class="row row-cols-2">
            <div class="col col-lg-4 col-md-12  p-3">
                <div>
                    
                    <div id="carouselExample" class="carousel slide ">
                        <div class="carousel-inner">
                            <div class="carousel-item active">
                               <img src="images/iphone-13-roze-frontandback_3_600x600_BGresize_16777215-tj.png" class="img-thumbnail"/> 
                            </div>
                            <div class="carousel-item">
                                <img src="images/iphone-13-roze-frontandback_3_600x600_BGresize_16777215-tj.png" class="img-thumbnail"/>
                            </div>
                            <div class="carousel-item">
                               <img src="images/iphone-13-roze-frontandback_3_600x600_BGresize_16777215-tj.png" class="img-thumbnail" />
                            </div>
                        </div>
                        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Previous</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Next</span>
                        </button>
                    </div>

                </div>
                <div class="text-center">
                    <asp:Button class="btn btn-warning mx-2  my-1" ID="Button1" runat="server" Text="ADD TO CART" Width="150" />
                    <asp:Button class="btn btn-success mx-2 my-1" ID="Button2" runat="server" Text="BUY NOW" Width="150" />
                </div>
            </div>
            <div class="col col-lg-7  col-md-12  p-3 mx-1 my-3 shadow">
                <h3>
                     <asp:Label ID="productName" runat="server" Text='<%# Eval("product_name") %>'></asp:Label>
                </h3>
                <h4>
                      &#8377 <asp:Label ID="productPrice" runat="server" Text='<%# Eval("product_price") %>'></asp:Label>
                </h4>
                <div class="row">

                   <h5 class="col-md-4">Seller name</h5>
                   <h5 class=" col-md-6 text-secondary">seller1</h5>
                </div>
                <div class="row row-cols-2">
                    <h5 class="col-md-4">Description</h5>
                    <p class=" col-md-6 text-secondary">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.</p>
                </div>
                <div>
                    <h5>Specification</h5>
                    <div>
                        <ul class="text-secondary">
                            <li>specification 1</li>
                            <li>specification 2</li>
                            <li>specification 3</li>
                            <li>specification 4</li>
                            <li></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div></div>
        <div></div>
        </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
