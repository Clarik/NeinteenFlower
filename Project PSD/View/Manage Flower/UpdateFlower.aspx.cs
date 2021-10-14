using Project_PSD.Controller;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Project_PSD.View
{
    public partial class UpdateFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.employeeSession();
            if (!IsPostBack)
            {
                
                List<string> type = FlowerTypeController.getFlowerType();

                ddlFTypeU.DataSource = type;
                ddlFTypeU.DataBind();
                if (Request.QueryString["id"] == null)
                    Response.Redirect("ViewFlower.aspx");
                else if (FlowerController.isFlowerIdAvaible(Request.QueryString["id"]).Length != 0)
                    Response.Redirect("ViewFlower.aspx");
                else
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    FlowerID.Text = "Update Flower : " + id;
                    MsFlower currFlower = FlowerController.searchFlower(id);

                    txtFNameU.Text = currFlower.FlowerName;
                    txtFImagePathU.Text = currFlower.FlowerImage;
                    txtFDescriptionU.Text = currFlower.FlowerDescription;

                    ddlFTypeU.SelectedIndex = currFlower.FlowerTypeID - 1;

                    txtPriceU.Text = currFlower.FlowerPrice.ToString();
                }
            }
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string FName = txtFNameU.Text;
            string FImage = txtFImagePathU.Text;
            string FDesc = txtFDescriptionU.Text;

            string FType = ddlFTypeU.SelectedValue.ToString();

            string FPrice = txtPriceU.Text;

            errorNameU.Text = FlowerController.flowerNameChecker(FName);
            errorImgU.Text = FlowerController.flowerImageChecker(FImage);
            errorDescU.Text = FlowerController.flowerDescriptionChecker(FDesc);
            errorPriceU.Text = FlowerController.flowerPriceChecker(FPrice);

            int errorCount = (errorNameU.Text + "" + errorImgU.Text + "" + errorDescU.Text + "" + errorPriceU.Text).Length;

            updateMessageU.Text = "Failed";

            if (errorCount > 0)
                return;

            int id = int.Parse(Request.QueryString["id"]);

            updateMessageU.Text = "Success";

            FlowerController.updateFlower(id, FName, FImage, FDesc, FType, FPrice);
        }

        protected void btnBackToViewFlower_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFlower.aspx");
        }
    }

}