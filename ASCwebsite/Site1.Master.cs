using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        int LoginData;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["LogInUserId"] != null)
                {

                    if (Session["LogInUserId"].Equals(""))
                    {
                        LoginSignupButton.Visible = true;
                        UserNameButton.Visible = false;
                        LogoutButton.Visible = false;
                        CartButton.Visible = false;
                    }
                    else
                    {
                        LoginSignupButton.Visible = false;
                        UserNameButton.Visible = true;
                        UserNameButton.Text = "Hello " + Session["LogInCustomerName"].ToString();
                        LogoutButton.Visible = true;
                        CartButton.Visible = true;
                    }
                }
                else
                {
                    LoginSignupButton.Visible = true;
                    UserNameButton.Visible = false;
                    LogoutButton.Visible = false;
                    CartButton.Visible = false;
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
           
         
        }
        public void ClearLoginId()
        {
            LoginData = 0;
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session["LogInUserId"] = "";
            Session["LogInCustomerName"] ="";
            LoginSignupButton.Visible = true;
            UserNameButton.Visible = false;
            LogoutButton.Visible = false;
            CartButton.Visible = false;
            Response.Redirect("homePage.aspx");

        }

        protected void LoginSignupButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginPage.aspx");
        }

        protected void CartButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CartPage.aspx");
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {  
            if(searchText.Text != "") {
            Session["searchText"] = searchText.Text;
            Response.Redirect("searchPage.aspx");     
            }
             
            
        }
    }
}