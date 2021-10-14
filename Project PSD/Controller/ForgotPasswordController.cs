using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Project_PSD.Controller
{
    public class ForgotPasswordController
    {
        public static string updatePassword(string email, string password)
        {
            if (EmployeeController.emailChecker(email).Equals("Email is taken"))
            {
                MsEmployee employee = EmployeeController.searchEmployee(email);
                EmployeeController.updateEmployee(employee.EmployeeID, employee.EmployeeEmail, password, employee.EmployeeName, employee.EmployeeDOB, employee.EmployeeGender, employee.EmployeePhone, employee.EmployeeAddress, employee.EmployeeSalary.ToString());
            }
            else if (MemberController.MemberEmailChecker(email).Equals("Email is taken"))
            {
                MsMember member = MemberController.searchMember(email);
                MemberController.updateMember(member.MemberID, member.MemberName, member.MemberDOB, member.MemberGender, member.MemberAddress, member.MemberPhone, member.MemberEmail, password);
            }
            return "Email doesn't exists in database please do register first!";
        }
        public static string generateCaptcha()
        {
            char[] CHAR = { 'a', 'A' };
            Random rand = new Random();
            var strBuilder = new StringBuilder();
            const int offSet = 26;
            // 3 Random character
            for (var i = 0; i < 3; i++)
            {
                var c = CHAR[rand.Next(CHAR.Length)];
                var @char = (char)rand.Next(c, c + offSet);
                strBuilder.Append(@char);
            }
            // 3 Random number
            for (var i = 0; i < 3; i++)
            {
                int randomNum = rand.Next(0, 9);
                strBuilder.Append(randomNum.ToString());
            }

            return strBuilder.ToString();
        }

        public static string captchaChecker(string captcha, string password)
        {
            if (!captcha.Equals(password))
                return "Password must be the same as captcha";
            return "";
        }
    }
}