using Project_PSD.Controller;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Project_PSD.View
{
    public partial class InsertFlower : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.employeeSession();
            if (!IsPostBack)
            {

                List<string> type = FlowerTypeController.getFlowerType();

                ddlFType.DataSource = type;
                ddlFType.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string FName = txtFName.Text;
            string FImage = txtFImagePath.Text;
            string FDesc = txtFDescription.Text;

            string FType = ddlFType.SelectedValue.ToString();

            string FPrice = txtPrice.Text;

            errorName.Text = FlowerController.flowerNameChecker(FName);
            errorImg.Text = FlowerController.flowerImageChecker(FImage);
            errorDesc.Text = FlowerController.flowerDescriptionChecker(FDesc);
            errorPrice.Text = FlowerController.flowerPriceChecker(FPrice);

            int errorCount = (errorName.Text + "" + errorImg.Text + "" + errorDesc.Text + "" + errorPrice.Text).Length;

            insertMessage.Text = "Wrong";

            if (errorCount > 1)
                return;

            insertMessage.Text = "Success";

            FlowerController.insertFlower(FName, FImage, FDesc, FType, FPrice);
        }


        protected void btnBackToViewFlower_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewFlower.aspx");
        }
    }
}