using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                int itemId = Convert.ToInt32(Request.QueryString["productId"]);

                string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=demoDb ;persist security info=False;integrated security=SSPI;";
              //  string constring = "data source=.;database=demoDb;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);


                SqlCommand cmd = new SqlCommand("SELECT * FROM productTable WHERE product_id='"+itemId+"'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                productDetails.DataSource = reader;
                productDetails.DataBind();
                con.Close();



            }


        }
    }
}