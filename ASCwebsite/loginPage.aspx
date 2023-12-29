<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="ASCwebsite.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-3" style="height: 100vh;">
        <div class="row">
            <div class="col-md-6  mx-auto">

                <div class="card p-3 shadow">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>

                                    <img src="images/profile-user.png" width="150" />
                                </center>
                            </div>

                        </div>


                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Customer Login</h3>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col text-danger">
                                 <center>
                                <asp:Label ID="LoginErorLabel" runat="server" Text=""></asp:Label>
                                 </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">

                                <label id="Member ID">User Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control loginTextField" ID="TextEmail" runat="server" placeholder="email"></asp:TextBox>
                                </div>

                                <label id="Password">Password</label>
                                <div class=" form-group">
                                    <asp:TextBox CssClass="form-control loginTextField" ID="TextPassword"
                                        runat="server" placeholder="password" TextMode="Password"></asp:TextBox>

                                </div>
                                <br />

                                <center>

                                    <div class="d-grid gap-2">

                                        <asp:Button class="btn btn-success py-2 " ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />




                                        <a class="btn btn-primary btn-block text-white py-2" href="signupPage.aspx">Sign up</a>

                                    </div>





                                </center>



                            </div>

                        </div>

                    </div>


                </div>
                <br />

                <a class="py-3" href="homePage.aspx"><< Back to homepage </a>
                <br>
                <br>
            </div>
        </div>

    </div>

</asp:Content>
