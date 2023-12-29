<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="paymentGatewayPage.aspx.cs" Inherits="ASCwebsite.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="container-fluid row my-2">

            <div class=" col-md-8">
                <div class="card py-3 shadow">
                    <div class="card-body">
                        <h5>Delivery address</h5>
                        <asp:Label CssClass="text-danger bg-danger-subtle" ID="ErrorLabel" runat="server" Text=""></asp:Label>
                        <div class="container row">
                            <div class="col-md-6">
                                <label>Name</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="NameText" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Mobile number</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="MobileNumberText" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="container row">
                            <div class="col-md-6">
                                <label>Pin code</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="PincodeText" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Location</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="LocationText" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="container row">

                        <div class="col-md-12">
                            <label>Address</label>
                            <div class="form-group">
                                <asp:TextBox class="form-control" ID="AddressText" TextMode="MultiLine" runat="server" maxlength="1200" Rows="3" Columns="10" Wrap="true"></asp:TextBox>
                            </div>
                        </div>
                        </div>
                        <div class="container row">
                            <div class="col-md-6">
                                <label>City</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="CityText" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>State</label>
                                <div class="form-group">                           
                                    <asp:DropDownList ID="statesDropDownList" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="container row">
                            <div class="col-md-6">

                                <label>Landmark</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="LandmarkText" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Alternate Phone number</label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="AltPhoneNumberText" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>


            <div class="col-md-4  py-3">
                <h5 class="bg-primary text-white p-2">Product details</h5>
                <asp:Label CssClass="fs-4" ID="ProductNameLabel" runat="server" Text="Label"></asp:Label>
                <div class="row">
                    <div class="col-6">
                        <h4>Price</h4>
                    </div>
                    <div class="col-6">
                        <asp:Label CssClass="fs-4" ID="ProductPriceLabel" runat="server" Text="Label"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <h4>Delivery charge</h4>
                        </div>
                        <div class="col-6">
                            <h4>40</h4>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6">
                            <h3>Total payable</h3>
                        </div>
                        <div class="col-6">
                            <asp:Label CssClass="fs-3" ID="TotalPriceLabel" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid row my-3 mx-2">
            <div class=" col-md-5">
                <h5 class="bg-primary text-white p-2">Payment details</h5>
                <div class="row">
                    <div class="col-2">
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </div>
                    <div class="col-2">
                        <h5>UPI</h5>
                    </div>
                </div>
                <div class="row">
                    <div class="col-2">
                        <asp:CheckBox ID="CheckBox2" runat="server" />
                    </div>
                    <div class="col-4">
                        <h5>Cach on delivery</h5>

                    </div>
                </div>
            </div>
            <center>
                <asp:Button CssClass="btn btn-success my-3 btn-block" ID="buyButton" runat="server" Style="width: 10rem" Text="Buy" OnClick="buyButton_Click" />
            </center>
        </div>
    </div>
</asp:Content>
