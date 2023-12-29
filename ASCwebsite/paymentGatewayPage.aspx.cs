using System;
using System.Collections.Generic;
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

            }
            catch (Exception ex) {
                Response.Write(ex.Message);

            }

        }

        protected void buyButton_Click(object sender, EventArgs e)
        {
           if(NameText.Text==""|| MobileNumberText.Text==""|| PincodeText.Text==""|| LocationText.Text==""|| AddressText.Text==""|| CityText.Text==""|| statesDropDownList.SelectedValue== "select state"|| LandmarkText.Text==""|| AltPhoneNumberText.Text == "")
            {
                ErrorLabel.Text = "Pleace fill the blanks";
            }
            else
            {
                ErrorLabel.Text = "";
                if (CheckBox2.Checked == true)
                {
                    
                }

            }
        }
    }
}