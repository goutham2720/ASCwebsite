using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        // SqlConnection con;
       // SqlConnection con;

       // SqlCommand cmd;

        SqlDataAdapter ada;


        DataTable dt;

        protected int CustomerIdGenerator(){
            string constring = "data source=.;database=demoDb;integrated security=true;";
            SqlConnection con = new SqlConnection(constring);
            if (con.State == ConnectionState.Closed) { 
            con.Open();
            }
            ada = new SqlDataAdapter("select max(user_id) from userTable ", con);

            dt = new DataTable();

            ada.Fill(dt);

            if (dt.Rows.Count > 0)
            {



                int code = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;

                Response.Write("code:"+code);
                return code;
                
               
            }
            else
            {
                return 100;
            }
            con.Close();
           

        }
       

        //SqlDataAdapter ada;
      //  DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            //  string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=demoDb ;persist security info=False;integrated security=SSPI;";

            // con = new SqlConnection();

            // con.ConnectionString = constring;

            //  con.Open();
           

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
            string constring = "data source=.;database=demoDb;integrated security=true;";
            SqlConnection con = new SqlConnection(constring);



            con.Open();

            Response.Write("Connected");
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
                    int UserId = CustomerIdGenerator();
                    Response.Write(UserId);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    
                  string signupdata = "INSERT INTO userTable (user_id,name,user_email,user_contact,user_name,user_password) values('"+ UserId + "','" + nameText.Text + "','" + emailText.Text + "','" + contactText.Text + "','"+ usernameText.Text + "','" + passwordText.Text + "')";
                    SqlCommand cmd = new SqlCommand(signupdata, con);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('Sign up successfully')</script>");
                    Response.Redirect("loginPage.aspx");
                    // Response.Write(nameText.Text);
                    //   Response.Write(emailText.Text);
                    //  Response.Write(usernameText.Text);
                    //  Response.Write(contactText.Text);
                    //  Response.Write(passwordText.Text);




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