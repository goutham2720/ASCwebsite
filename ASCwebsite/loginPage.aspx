<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="ASCwebsite.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-3" style="height:100vh;">
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
                            <div class="col">

                                <label id="Member ID">User Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextEmail" runat="server" placeholder="email" ></asp:TextBox>     
                                </div>

                                <label id="Password">Password</label>
                                <div class=" form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextPassword"
                                        runat="server" placeholder="password" ></asp:TextBox>

                                </div>
                                <br />

                                <center>

                                    <div class="form-group ">

                                        <asp:Button class="btn btn-success my-2 loginPageButtons " ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
                                        <br />
                                        <a class="btn btn-info text-white loginPageButtons"  href="signupPage.aspx">Sign up</a>

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
