﻿using System;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                //string constring = @"Data Source=DESKTOP-DJVB3P4;Initial Catalog=productTable ;persist security info=False;integrated security=SSPI;";
            string constring = "data source=.;database=demoDb;integrated security=true;";
            SqlConnection   con = new SqlConnection(constring);

           
            SqlCommand cmd = new SqlCommand("SELECT * FROM productTable", con);
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

        protected void ElectronicsButton_Click(object sender, EventArgs e)
        {   
            Session["SearchCategory"] = "Electronics";
            Session["searchText"] = "";
            Response.Redirect("searchPage.aspx");
            
        }

        protected void GroceryButton_Click(object sender, EventArgs e)
        {
           
            Session["SearchCategory"] = "Grocery";
            Session["searchText"] = "";
           
            Response.Redirect("searchPage.aspx");
        }

        protected void AppliancesButton_Click(object sender, EventArgs e)
        {
           
            Session["SearchCategory"] = "Appliances";
            Session["searchText"] = "";
            Response.Redirect("searchPage.aspx");
            
        }
    }
}