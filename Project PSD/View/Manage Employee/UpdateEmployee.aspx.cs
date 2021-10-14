using Project_PSD.Controller;
using Project_PSD.Model;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.Manage_Employee
{
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.adminSession();
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                    Response.Redirect("ManageEmployee.aspx");
                else if (EmployeeController.isEmployeeIdAvailable(Request.QueryString["id"]).Length != 0)
                    Response.Redirect("ManageEmployee.aspx");
                else
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    EmployeeID.Text = "Update Employee : " + id;
                    MsEmployee currEmployee = EmployeeController.searchEmployee(id);

                    txtEEmail.Text = currEmployee.EmployeeEmail;
                    txtEPassword.Text = currEmployee.EmployeePassword;
                    txtEName.Text = currEmployee.EmployeeName;
                    txtAge.Text = currEmployee.EmployeeDOB.ToString("yyyy-MM-dd");
                    txtPhoneNumber.Text = currEmployee.EmployeePhone;
                    txtAddress.Text = currEmployee.EmployeeAddress;
                    txtSalary.Text = currEmployee.EmployeeSalary.ToString();

                    if (EmployeeController.searchEmployee(id).EmployeeGender == "Male")
                    {
                        Male.Checked = true;
                    }
                    else
                    {
                        Female.Checked = true;
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            string EEmail = txtEEmail.Text;
            string EPassword = txtEPassword.Text;
            string EName = txtEName.Text;
            string EPhoneNumber = txtPhoneNumber.Text;
            string EAddress = txtAddress.Text;
            string ESalary = txtSalary.Text;
            string EGender = "none";
            DateTime EDOB = Convert.ToDateTime(txtAge.Text);

            if (Male.Checked)
            {
                EGender = "Male";
            }
            else if (Female.Checked)
            {
                EGender = "Female";
            }

            errorEEmail.Text = EmployeeController.emailChecker(EEmail);
            errorEPassword.Text = EmployeeController.passwordChecker(EPassword);
            errorEName.Text = EmployeeController.nameChecker(EName);
            errorEPhoneNumber.Text = EmployeeController.phoneNumberChecker(EPhoneNumber);
            errorEAddress.Text = EmployeeController.addressChecker(EAddress);
            errorSalary.Text = EmployeeController.salaryChecker(ESalary);
            errorEAge.Text = EmployeeController.ageChecker(EDOB);

            int errorCount = (errorEEmail.Text + "" + errorEPassword.Text + "" + errorEName.Text + "" + errorEAge.Text + "" + errorEGender.Text + "" + errorEPhoneNumber.Text + "" + errorEAddress.Text + "" + errorSalary.Text).Length;

            if (errorCount > 1)
            {
                updateMessage.Text = "Failed";
                return;
            }

            int id = int.Parse(Request.QueryString["id"]);

            updateMessage.Text = "Success";

            EmployeeController.updateEmployee(id, EEmail, EPassword, EName, EDOB, EGender, EPhoneNumber, EAddress, ESalary);
            
        }

        protected void btnBackToManagePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewEmployee.aspx");
        }
    }
}