using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["searchText"]);
            try
            {

                //string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=productTable ;persist security info=False;integrated security=SSPI;";
                string constring = "data source=.;database=demoDb;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);


                SqlCommand cmd = new SqlCommand("SELECT * FROM productTable WHERE product_name LIKE '%"+Session["searchText"]+"%'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                repeatProduct.DataSource = reader;
                repeatProduct.DataBind();
                con.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}