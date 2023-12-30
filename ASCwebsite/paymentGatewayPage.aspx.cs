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
    public partial class WebForm2 : System.Web.UI.Page
    {

        SqlDataAdapter ada;


        DataTable dt;
        protected int TransactionIdGenerator()
        {
            string constring = "data source=.;database=demoDb;integrated security=true;";
            SqlConnection con = new SqlConnection(constring);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            ada = new SqlDataAdapter("select max(transaction_id) from transactionTable ", con);

            dt = new DataTable();

            ada.Fill(dt);

            if (dt.Rows.Count > 0)
            {



                int code = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;

                
                return code;


            }
            else
            {
                return 100;
            }
            con.Close();


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
            List<string> states = new List<string>();
            states.Add("select state");
            states.Add("Andhra Pradesh");
            states.Add("Arunachal Pradesh");
            states.Add("Assam");
            states.Add("Bihar");
            states.Add("Chhattisgarh");
            states.Add("Goa");
            states.Add("Gujarat");
            states.Add("Haryana");
            states.Add("Himachal Pradesh");
            states.Add("Jharkhand");
            states.Add("Karnataka");
            states.Add("Kerala");
            states.Add("Madhya Pradesh");
            states.Add("Maharashtra");
            states.Add("Manipur");
            states.Add("Meghalaya");
            states.Add("Mizoram");
            states.Add("Nagaland");
            states.Add("Odisha");
            states.Add("Punjab");
            states.Add("Rajasthan");
            states.Add("Sikkim");
            states.Add("Tamil Nadu");
            states.Add("Telangana");
            states.Add("Tripura");
            states.Add("Uttar Pradesh");
            states.Add("Uttarakhand");
            states.Add("West Bengal");
            statesDropDownList.DataSource = states;
            statesDropDownList.DataBind();
            }


            try {
                ProductNameLabel.Text = (string)Session["BuyProductName"];
                ProductPriceLabel.Text = (string)Session["BuyProductPrice"];
                int totalPrice =  Convert.ToInt32(Session["BuyProductPrice"]) + 40;
                TotalPriceLabel.Text = Convert.ToString(totalPrice);
                Session["BuyProductTotalPrice"] = totalPrice;

            }
            catch (Exception ex) {
                Response.Write(ex.Message);

            }

        }

        protected void buyButton_Click(object sender, EventArgs e)
        {
            string constring = "data source=.;database=demoDb;integrated security=true;";
            SqlConnection con = new SqlConnection(constring);


            if (NameText.Text==""|| MobileNumberText.Text==""|| PincodeText.Text==""|| LocationText.Text==""|| AddressText.Text==""|| CityText.Text==""|| statesDropDownList.SelectedValue== "select state"|| LandmarkText.Text==""|| AltPhoneNumberText.Text == "")
            {
                ErrorLabel.Text = "Pleace fill the blanks";
            }
            else
            {
                try { 
                ErrorLabel.Text = "";
                if (CheckBox2.Checked == true)
                {

                    int transId=TransactionIdGenerator();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string transactiondata = "INSERT INTO transactionTable (transaction_id,user_id,user_name,contact_number,pincode,location,user_address,city,state,landmark,alt_contact_number,order_status,product_price,total_pay,product_name) values('"+ transId + "','" + Session["LogInUserId"] + "','"+ NameText.Text + "','" + MobileNumberText.Text + "','"+ PincodeText.Text + "','"+ LocationText.Text + "','"+ AddressText.Text + "','"+ CityText.Text + "','"+ statesDropDownList.SelectedValue + "','"+ LandmarkText.Text + "','" + AltPhoneNumberText.Text + "','purchased','" + Session["BuyProductPrice"] + "','"+ Session["BuyProductTotalPrice"] + "','"+ Session["BuyProductName"] + "')";
                    SqlCommand cmd = new SqlCommand(transactiondata, con);
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Oder is placed successfully')</script>");
                    con.Close();
                    Response.Redirect("orderPage.aspx");
                }
                }
                catch(Exception ex)
                {
                    Response.Write(ex.Message);
                }

            }
        }
    }
}