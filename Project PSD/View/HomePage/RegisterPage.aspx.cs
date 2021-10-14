using Project_PSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["roles"] != null)
                LoginController.gotoHomePage();
        }

        protected void btnLoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void RegisterMember_Click(object sender, EventArgs e)
        {
            string MemberName = txtMemberName.Text;
            string MemberGender = "none";
            if (MaleMember.Checked)
            {
                MemberGender = "Male";
            }
            else if (FemaleMember.Checked)
            {
                MemberGender = "Female";
            }
            DateTime MemberDOB = System.DateTime.Now;
            if (txtMemberDOB != null)
            {
                MemberDOB = Convert.ToDateTime(txtMemberDOB.Text);
            }
            string MemberAddress = txtMemberAddress.Text;
            string MemberPhone = txtMemberPhone.Text;
            string MemberEmail = txtMemberEmail.Text;
            string MemberPassword = txtMemberPassword.Text;

            errName.Text = MemberController.MemberNameChecker(MemberName);
            errDOB.Text = MemberController.MemberAgeChecker(MemberDOB);
            errAddress.Text = MemberController.MemberAddressChecker(MemberAddress);
            errEmail.Text = MemberController.MemberEmailChecker(MemberEmail);
            errPass.Text = MemberController.MemberPasswordChecker(MemberPassword);

            int errorCount = (errName.Text + "" + errDOB.Text + "" + errAddress.Text + "" + errEmail.Text + "" + errPass.Text).Length;


            if (errorCount > 1)
            {
                registerMessage.Text = "Wrong";
                return;
            }

            registerMessage.Text = "Success";

            MemberController.insertMember(MemberName, MemberDOB, MemberGender, MemberAddress, MemberPhone, MemberEmail, MemberPassword);
        }

        protected void btnBacktoHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}