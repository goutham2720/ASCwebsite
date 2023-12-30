using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class WebForm8 : System.Web.UI.Page
    {

        protected void CancelOrder(string productname)
        {
            try
            {
                string constring = "data source=.;database=demoDb;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE transactionTable SET order_status='canceled' WHERE user_id='" + Session["LogInUserId"] + "' AND product_name='" + productname + "' ", con);
                cmd1.ExecuteNonQuery();
                con.Close();

                Response.Redirect("orderPage.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string productName = Request.QueryString["productName"];
            try
            {
                if (Session["LogInUserId"] != null && Session["LogInUserId"] != "")
                {
                    string constring = "data source=.;database=demoDb;integrated security=true;";
                    SqlConnection con = new SqlConnection(constring);

                    //string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=productTable ;persist security info=False;integrated security=SSPI;";


                    SqlCommand cmd = new SqlCommand("SELECT * FROM transactionTable WHERE user_id='" + Session["LogInUserId"] + "' AND order_status='purchased'", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    repeatProduct.DataSource = reader;
                    repeatProduct.DataBind();
                    con.Close();



                   if (productName != null && productName != "")
                    {
                        CancelOrder(productName);
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