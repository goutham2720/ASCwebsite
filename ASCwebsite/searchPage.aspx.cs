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
            
            try
            {
                

                //string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=productTable ;persist security info=False;integrated security=SSPI;";
                string constring = "data source=.;database=demoDb;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);


                
                if ( Session["SearchCategory"]!=null&& Session["searchText"]=="") { 
                  SqlCommand cmd1 = new SqlCommand("SELECT * FROM productTable WHERE  category='" + Session["SearchCategory"] + "' ", con);
                  con.Open();
                  SqlDataReader reader1 = cmd1.ExecuteReader();
                  if (reader1.HasRows) { 
                  repeatProduct.DataSource = reader1;
                  repeatProduct.DataBind();
                  cmd1.Connection.Close();
                  cmd1.Connection.Dispose();
                        con.Close();


                    }
                    else
                   {
                    SearchError.Text = "No item found";
                    }
                }
                if (Session["searchText"] != null ) { 
                     SqlCommand cmd = new SqlCommand("SELECT * FROM productTable WHERE product_name LIKE '%"+Session["searchText"]+ "%' OR category LIKE '%"+Session["searchText"]+ "%' ", con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        repeatProduct.DataSource = reader;
                        repeatProduct.DataBind();
                       cmd.Connection.Close();
                       cmd.Connection.Dispose();

                        con.Close();
                }
                else
                    {
                        SearchError.Text = "No item found";
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