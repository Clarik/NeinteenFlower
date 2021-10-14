using Project_PSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (EmployeeController.searchEmployee("admin") == null)
                EmployeeController.insertEmployee("admin", "admin", "", DateTime.Today, "", "", "", "0");


            LoginController.isCookieOrSessionAvaible();
            if (HttpContext.Current.Session["user"] != null)
                LoginController.gotoHomePage();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            bool remember = remember_Me.Checked;
            errorLogin.Text = LoginController.login(email, password, remember);
        }

        protected void btnBacktoHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}