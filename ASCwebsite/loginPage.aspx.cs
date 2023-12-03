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
    public partial class WebForm3 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        public void Clear()
        {
            TextEmail.Text = "";
            TextPassword.Text = "";
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // con.Open();

                //  ada = new SqlDataAdapter("select * from assignement where user_email=  " + TextLoginEmail.Text + "  ", con);

                // dt = new DataTable();

                // 
                string constring = "data source=.;database=demoDb;integrated security=true;";
                SqlConnection con = new SqlConnection(constring);


                
                con.Open();
                string qry = "SELECT * FROM  userTable WHERE user_email='" + TextEmail.Text + "' AND user_password='" + TextPassword.Text+ "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    Response.Redirect("HomePage.aspx");

                    Response.Write("successfull");
                    con.Close();

                }
                else
                {
                    Response.Write("failed ");
                }


                // ada.Fill(dt);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            Clear();
            
        }

    }
}