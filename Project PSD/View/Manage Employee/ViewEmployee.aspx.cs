using Project_PSD.Controller;
using Project_PSD.Handler;
using Project_PSD.Model;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.Manage_Employee
{
    public partial class ViewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.adminSession();
            getEmployeeList();
        }

        void getEmployeeList()
        {
            List<MsEmployee> EmployeeList = EmployeeController.getAllEmployee();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Date of Birth");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Address");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("Password");
            dt.Columns.Add("Salary");


            foreach (MsEmployee employee in EmployeeList)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = employee.EmployeeID;
                dr["Name"] = employee.EmployeeName;
                dr["Date of Birth"] = employee.EmployeeDOB.ToString("MM/dd/yy");
                dr["Gender"] = employee.EmployeeGender;
                dr["Address"] = employee.EmployeeAddress;
                dr["Phone"] = employee.EmployeePhone;
                dr["Email"] = employee.EmployeeEmail;
                dr["Password"] = employee.EmployeePassword;
                dr["Salary"] = employee.EmployeeSalary;
                dt.Rows.Add(dr);
            }

            Employee_Grid.DataSource = dt;
            Employee_Grid.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (Request.QueryString["id"] == null) ;
            else if (!int.TryParse(Request.QueryString["id"], out id)) ;
            else
            {
                id = int.Parse(Request.QueryString["id"]);
                deleteEmployee(id);
            }
            backToPage();
        }

        void deleteEmployee(int id)
        {
            EmployeeController.deleteEmployeeByID(id);
        }

        void backToPage()
        {
            Response.Redirect("ViewEmployee.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateEmployee.aspx");
        }


        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertEmployee.aspx");
        }
    }
}