<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signupPage.aspx.cs" Inherits="ASCwebsite.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container my-3 " style="height: 100vh;">
        <div class="row ">
            <div class="col-md-7 mx-auto">

                <div class="card p-3 shadow">
                    <div class="card-body ">
                    </div>

                    <div class="row">
                        <div class="col">
                        </div>
                    </div>

                    <div class="row">
                        <div class="col">
                            <center>
                                <h6>Customer Signup</h6>

                            </center>

                        </div>
                    </div>


                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>


                    <div class="row">
                        &nbsp&nbsp &nbsp
                        <div class="col-md-11">
                            <label>Name</label>
                            <asp:Label ID="Name" runat="server" Text=""></asp:Label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="nameText" runat="server" placeholder="First Name"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp&nbsp &nbsp
                        <div class="col-md-11">
                            <label>Email Id</label>
                            <asp:Label ID="UserEmail" runat="server" Text=""></asp:Label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="emailText" runat="server" placeholder="Email Id"></asp:TextBox>
                            </div>

                        </div>
                    </div>
                    <div class="row">
                        &nbsp&nbsp &nbsp   
                        <div class="col-md-11">
                            <label>Contact No</label>
                            <asp:Label ID="UserContact" runat="server" Text=""></asp:Label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="contactText" runat="server" placeholder="Contact No"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        &nbsp&nbsp &nbsp   
                        <div class="col-md-11">
                            <label>User Name</label>
                            <asp:Label ID="UserName" runat="server" Text=""></asp:Label>
                         
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="usernameText" runat="server" placeholder="Username"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        &nbsp&nbsp &nbsp   
                        <div class="col-md-11">
                            <label>Password</label>
                            <asp:Label ID="UserPassword" runat="server" Text=""></asp:Label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="passwordText" runat="server" placeholder="Pssword"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        &nbsp&nbsp &nbsp   
                        <div class="col-md-11">
                            <label>Confirm Password</label>
                            <asp:Label ID="UserConformPassword" runat="server" Text=""></asp:Label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="confirmpasswordText" runat="server" placeholder="Confirm Password"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <br />

                    <div class="form-group">
                        <center>
                            <asp:Button class="btn btn-success btn-block my-3" ID="SignUpButton" runat="server" Text="SignUp" Width="300" OnClick="SignUpButton_Click" /></center>
                    </div>





                </div>


            </div>

        </div>
    </div>



</asp:Content>
