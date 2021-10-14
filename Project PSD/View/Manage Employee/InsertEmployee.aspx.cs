using Project_PSD.Controller;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.Manage_Employee
{
    public partial class InsertEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();

            LoginController.adminSession();
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

            string EEmail = txtEEmail.Text;
            string EPassword = txtEPassword.Text;
            string EName = txtEName.Text;
            string EmployeeGender = "none";
            string EPhoneNumber = txtPhoneNumber.Text;
            string EAddress = txtAddress.Text;
            string ESalary = txtSalary.Text;

            if (Male.Checked)
            {
                EmployeeGender = "Male";
            }
            else if (Female.Checked)
            {
                EmployeeGender = "Female";
            }

            DateTime EDOB = System.DateTime.Now;
            if (txtEmployeeDOB != null)
            {
                EDOB = Convert.ToDateTime(txtEmployeeDOB.Text);
            }


            errorEEmail.Text = EmployeeController.emailChecker(EEmail);
            errorEPassword.Text = EmployeeController.passwordChecker(EPassword);
            errorEName.Text = EmployeeController.nameChecker(EName);
            errorEAge.Text = EmployeeController.ageChecker(EDOB);
            errorEPhoneNumber.Text = EmployeeController.phoneNumberChecker(EPhoneNumber);
            errorEAddress.Text = EmployeeController.addressChecker(EAddress);
            errorSalary.Text = EmployeeController.salaryChecker(ESalary);

            int errorCount = (errorEEmail.Text + "" + errorEPassword.Text + "" + errorEName.Text + "" + errorEAge.Text + "" + errorEGender.Text + "" + errorEPhoneNumber.Text + "" + errorEAddress.Text + "" + errorSalary.Text).Length;


            if (errorCount > 1)
            {
                insertMessage.Text = "Failed";
                return;
            }

            insertMessage.Text = "Success";
            EmployeeController.insertEmployee(EEmail, EPassword, EName, EDOB, EmployeeGender, EPhoneNumber, EAddress, ESalary);
        }

        protected void btnBackToManagePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewEmployee.aspx");
        }
    }
}