using Project_PSD.Controller;
using Project_PSD.Model;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.Manage_Member
{
    public partial class ViewMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.adminSession();
            getMemberList();
        }


        void getMemberList()
        {
            List<MsMember> MemberList = MemberController.getAllMember();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date of Birth");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Address");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Password");


            foreach (MsMember Member in MemberList)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = Member.MemberID;
                dr["Name"] = Member.MemberName;
                dr["Date of Birth"] = Member.MemberDOB.ToString("MM/dd/yy");
                dr["Gender"] = Member.MemberGender;
                dr["Address"] = Member.MemberAddress;
                dr["Phone"] = Member.MemberPhone;
                dr["Email"] = Member.MemberEmail;
                dr["Password"] = Member.MemberPassword;
                dt.Rows.Add(dr);
            }

            Member_Grid.DataSource = dt;
            Member_Grid.DataBind();
        }


        protected void InsertMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMember.aspx");
        }

        protected void DeleteMember_Click(object sender, EventArgs e)
        {
            int id;
            if (Request.QueryString["id"] == null) ;
            else if (!int.TryParse(Request.QueryString["id"], out id)) ;
            else
            {
                id = int.Parse(Request.QueryString["id"]);
                MemberController.deleteMember(id);
            }
            Response.Redirect("ViewMember.aspx");
        }

    }
}