using Project_PSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.HomePage
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            hideDiv();
            if (HttpContext.Current.Session["roles"] == null)
                guestBtnList.Visible = true;
            else if (HttpContext.Current.Session["roles"].Equals("member"))
                memberBtnList.Visible = true;
            else if (HttpContext.Current.Session["roles"].Equals("employee"))
                employeeBtnList.Visible = true;
            else
                adminBtnList.Visible = true;
        }

        private void hideDiv()
        {
            guestBtnList.Visible = false;
            employeeBtnList.Visible = false;
            memberBtnList.Visible = false;
            adminBtnList.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPasswordPage.aspx");
        }


        protected void btnManageMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Manage Member/ViewMember.aspx");
        }

        protected void btnManageEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Manage Employee/ViewEmployee.aspx");
        }

        protected void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pre-Order/ViewTr.aspx");
        }

        protected void btnPreOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pre-Order/PreOrder.aspx");
        }

        protected void btnManageFlower_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Manage Flower/ViewFlower.aspx");
        }

        
    }
}