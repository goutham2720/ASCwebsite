using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con;

        SqlCommand cmd;

        SqlDataAdapter ada;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=demoDb ;persist security info=False;integrated security=SSPI;";

            con = new SqlConnection();

            con.ConnectionString = constring;

            con.Open();

            Response.Write("Connected");

        }
        public void Clear()
        {
            nameText.Text = "";
            emailText.Text = "";
            usernameText.Text = "";
            contactText.Text = "";
            passwordText.Text = "";
            confirmpasswordText.Text = "";



        }

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameText.Text == "" || emailText.Text == "" || usernameText.Text == "" || contactText.Text==""|| passwordText.Text == "" || confirmpasswordText.Text == "" || confirmpasswordText.Text != passwordText.Text)
                {
                    if (nameText.Text == "")
                    {
                        Name.Text = "Enter name";
                    }
                    else
                    {
                        Name.Text = "";
                    }
                    if (emailText.Text == "")
                    {
                        UserEmail.Text = "Enter user email";
                    }
                    else
                    {
                        UserEmail.Text = "";
                    }
                    if (usernameText.Text== "")
                    {
                        UserName.Text = "Enter user Name";
                    }
                    else
                    {
                        UserName.Text = "";
                    }
                    if (contactText.Text == "")
                    {
                        UserContact.Text = "Enter user contact number";
                    }
                    else
                    {
                        UserContact.Text = "";
                    }
                    if (passwordText.Text == "")
                    {
                        UserPassword.Text = "Enter password";
                    }
                    else
                    {
                        UserPassword.Text = "";
                    }
                    if (confirmpasswordText.Text != passwordText.Text)
                    {
                        UserConformPassword.Text = "Password does not match";
                    }
                    else
                    {
                        UserConformPassword.Text = "";
                    }
                }
                else
                {
                   
                   string s = "INSERT INTO userTable (name,user_email,user_contact,user_name,user_password) values('" + nameText.Text + "','" + emailText.Text + "','" + contactText.Text + "','"+ usernameText.Text + "','" + passwordText.Text + "')";





                    cmd = new SqlCommand(s, con);
                    Response.Redirect("loginPage.aspx");

                      cmd.ExecuteNonQuery();

                    con.Close();
                    Clear();
                }


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}