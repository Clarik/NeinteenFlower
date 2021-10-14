using Project_PSD.Controller;
using Project_PSD.Model;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Web;

namespace Project_PSD.View.Manage_Member
{
    public partial class UpdateMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.adminSession();
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                    Response.Redirect("ViewMember.aspx");
                else if (MemberController.isMemberIdAvaible(Request.QueryString["id"]).Length != 0)
                    Response.Redirect("ViewMember.aspx");
                else
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    MemberID.Text = "Update Member : " + id;
                    MsMember currMember = MemberController.searchMember(id);
                    txtMemberName.Text = currMember.MemberName;
                    txtMemberDOB.Text = currMember.MemberDOB.ToString("yyyy-MM-dd");
                    if(MemberController.searchMember(id).MemberGender == "Male")
                    {
                        MaleMember.Checked = true;
                    }
                    else
                    {
                        FemaleMember.Checked = true;
                    }
                    txtMemberAddress.Text = currMember.MemberAddress;
                    txtMemberPhone.Text = currMember.MemberPhone;
                    txtMemberEmail.Text = currMember.MemberEmail;
                    txtMemberPassword.Text = currMember.MemberPassword;
                }
            }
        }

        protected void ViewMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMember.aspx");
        }

        protected void MemberUpdate_Click(object sender, EventArgs e)
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
            DateTime  MemberDOB = Convert.ToDateTime(txtMemberDOB.Text);
            string MemberAddress = txtMemberAddress.Text;
            string MemberPhone = txtMemberPhone.Text;
            string MemberEmail = txtMemberEmail.Text;
            string MemberPassword = txtMemberPassword.Text;

            errNameU.Text = MemberController.MemberNameChecker(MemberName);
            errDOBU.Text = MemberController.MemberAgeChecker(MemberDOB);
            errAddressU.Text = MemberController.MemberAddressChecker(MemberAddress);
            errEmailU.Text = MemberController.MemberEmailChecker(MemberEmail);
            errPassU.Text = MemberController.MemberPasswordChecker(MemberPassword);

            int errorCount = (errNameU.Text + "" + errDOBU.Text + "" + errAddressU.Text + "" + errEmailU.Text + "" + errPassU.Text).Length;


            if (errorCount > 1)
            {
                UpdateMessage.Text = "Wrong";
                return;
            }
            int id = int.Parse(Request.QueryString["id"]);
            UpdateMessage.Text = "Success";

            MemberController.updateMember(id,MemberName, MemberDOB, MemberGender, MemberAddress, MemberPhone, MemberEmail, MemberPassword);
            Response.Redirect("ViewMember.aspx");
        }
    }
}