using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASCwebsite
{
    public partial class WebForm6 : System.Web.UI.Page
    {

       

        public object NameOfProductLabel { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    int itemId = Convert.ToInt32(Request.QueryString["productId"]);
                   if(itemId != null) { 
                    string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=demoDb ;persist security info=False;integrated security=SSPI;";
                    //  string constring = "data source=.;database=demoDb;integrated security=true;";
                    SqlConnection con = new SqlConnection(constring);


                    SqlCommand cmd = new SqlCommand("SELECT * FROM productTable WHERE product_id='" + Convert.ToInt32(Request.QueryString["productId"]) + "'", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                   // product.DataSource = reader;
                   // product.DataBind();
                   
                    
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {


                                productNameLabel.Text = reader.GetValue(1).ToString();
                               Session[ "ProductName"]= reader.GetValue(1).ToString();

                               productPriceLabel.Text = reader.GetValue(2).ToString();
                                Session["ProductPrice"] = reader.GetValue(2).ToString();
                                Session["ProductId"] = reader.GetValue(0).ToString();


                            }

                      



                    }
                    else
                    {

                    }
                   
                    con.Close();
                    }
                   
                }

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void AddCartButton_Click(object sender, EventArgs e)
        {
            string constring = "data source=.;database=demoDb;integrated security=true;";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
           
            try
            {
               
                if(Session["LogInUserId"] != null)
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO cartTable (user_id,product_id,product_name) values('"+ Session["LogInUserId"] + "','"+ Session["ProductId"] + "','"+ Session["ProductName"] + "')", con);
                    
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    Response.Redirect("loginPage.aspx");
                }

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
                
            }
        }

        protected void BuyNowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["LogInUserId"] != null)
                {
                    Session["BuyProductName"] = Session["ProductName"];
                    Session["BuyProductPrice"] = Session["ProductPrice"];
                    Session["BuyProductId"] = Session["ProductId"];
                    Response.Redirect("paymentGatewayPage.aspx");
                }
                else
                {
                    Response.Redirect("loginPage.aspx");
                }

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}