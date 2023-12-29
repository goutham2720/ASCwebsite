using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void DeleatFromCart(int id)
        {
            try
            {
                string constring = "data source=.;database=demoDb;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("DELETE  FROM cartTable WHERE user_id='" + Session["LogInUserId"] + "' AND product_id='" + id + "' ", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                
                Response.Redirect("CartPage.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(Request.QueryString["cartProductId"]);
           
            try
            {
                if (Session["LogInUserId"] != null&& Session["LogInUserId"]!="")
                { 
                string constring = "data source=.;database=demoDb;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);

                //string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=productTable ;persist security info=False;integrated security=SSPI;";


                SqlCommand cmd = new SqlCommand("SELECT * FROM cartTable WHERE user_id='" + Session["LogInUserId"] + "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                repeatProduct.DataSource = reader;
                repeatProduct.DataBind();
                con.Close();

               

            if(itemId != null && itemId!=0)
            {
                DeleatFromCart(itemId);
            }
             }
              
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
        }

       
    }
}