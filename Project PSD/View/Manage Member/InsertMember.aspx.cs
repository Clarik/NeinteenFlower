using Project_PSD.Controller;
using System;
using System.Web;

namespace Project_PSD.View.Manage_Member
{
    public partial class InsertMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.adminSession();
        }

        protected void ViewMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMember.aspx");
        }

        protected void MemberInsert_Click(object sender, EventArgs e)
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

            int errorCount = (errName.Text + "" + errDOB.Text + "" + errAddress.Text + "" + errEmail.Text + "" +errPass.Text).Length;
            

            if (errorCount > 1)
            {
                insertMessage.Text = "Wrong";
                return;
            }

            insertMessage.Text = "Success";

            MemberController.insertMember(MemberName,MemberDOB,MemberGender,MemberAddress,MemberPhone,MemberEmail,MemberPassword);
        }
    }
}