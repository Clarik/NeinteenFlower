using Project_PSD.Controller;
using System;
using System.Web;

namespace Project_PSD.View
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["roles"] == null)
                Btn.Visible = false;
        }

        private void hideDiv()
        {
            Btn.Visible = true;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("../HomePage/HomePage.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginController.logout();
            Response.Redirect("../HomePage/HomePage.aspx");
        }
    }
}