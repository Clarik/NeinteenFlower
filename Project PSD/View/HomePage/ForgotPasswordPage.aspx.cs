using Project_PSD.Controller;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.HomePage
{
    public partial class ForgotPasswordPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            if (HttpContext.Current.Session["roles"] != null)
                LoginController.gotoHomePage();
            if (!IsPostBack)
            {
                var captcha = ForgotPasswordController.generateCaptcha();
                txtCaptcha.Text = captcha;
            }
        }

        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            errorPassword.Text = ForgotPasswordController.captchaChecker(txtCaptcha.Text, password);
            
            if (errorPassword.Text.Length > 0)
                return;

            bool success = false;
            if (email.Length == 0)
                errorEmail.Text = "Email can't be empty";
            else
                errorEmail.Text = ForgotPasswordController.updatePassword(email, password);

            resetPasswordMessage.Text = success ? "Success" : "Failed";
            
        }

        protected void btnBacktoHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        

       

    }
}