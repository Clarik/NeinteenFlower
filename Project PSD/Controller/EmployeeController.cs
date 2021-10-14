using Project_PSD.Handler;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace Project_PSD.Controller
{
    public class EmployeeController
    {
        public static List<MsEmployee> getAllEmployee()
        {
            return EmployeeHandler.getAllEmployee();
        }

        public static void deleteEmployeeByID(int id)
        {
            EmployeeHandler.deleteEmployeeByID(id);
        }

        public static void insertEmployee(string email, string password, string name, System.DateTime dOB, string gender, string phoneNumber, string address, string salary)
        {
            EmployeeHandler.insertEmployee(email, password, name, dOB, gender, phoneNumber, address, int.Parse(salary));
        }

        public static MsEmployee searchEmployee(int id)
        {
            return EmployeeHandler.searchEmployeeById(id);
        }

        public static MsEmployee searchEmployee(string email)
        {
            return EmployeeHandler.searchEmployeeByEmail(email);
        }


        public static void updateEmployee(int id, string email, string password, string name, System.DateTime dOB, string gender, string phoneNumber, string address, string salary)
        {
            EmployeeHandler.updateEmployee(id, email, password, name, dOB, gender, phoneNumber, address, int.Parse(salary));
        }

        public static string isEmployeeIdAvailable(string id)
        {
            int EId;
            if (int.TryParse(id, out EId) == false)
                return "error";
            EId = int.Parse(id);
            MsEmployee employee = searchEmployee(id);
            if (employee == null)
                return "error";
            return "";
        }

        public static string emailChecker(string email)
        {
            MsEmployee EmailExist = searchEmployee(email);
            if (EmailExist != null)
                return "Email is taken";
            if (email.EndsWith("@employee.com") == false)
                return "Email must be ending in @employee.com";
            return "";
        }

        public static string passwordChecker(string password)
        {
            if (password.Length < 3)
                return "Password length minimal 3 character";
            if (password.Length > 20)
                return "Password length maximal 20 character";
            return "";
        }

        public static string nameChecker(string name)
        {
            if (name.Length < 3)
                return "Employee name length minimal 3 character";
            if (name.Length > 20)
                return "Employee name length maximal 20 character";
            return "";
        }

        public static string ageChecker(System.DateTime dob)
        {
            int age = System.DateTime.Today.Year - dob.Year;
            if (age < 17 || dob == null)
                return "Member must be over 17";
            return "";
        }

        public static string genderChecker(string gender)
        {
            if (gender.Length == 0)
                return "Gender must be chosen";
            return "";
        }

        public static string phoneNumberChecker(string phoneNumber)
        {
            int EPhoneNumber;
            if (int.TryParse(phoneNumber, out EPhoneNumber) == false)
                return "Phone Number must be numeric";
            return "";
        }

        public static string addressChecker(string address)
        {
            if (address.Contains("Street") == false)
                return "Address must contain the word \"Street\"";
            return "";
        }

        public static string salaryChecker(string salary)
        {
            int ESalary;
            if (int.TryParse(salary, out ESalary) == false)
                return "Salary must be numeric";
            if (ESalary < 100 || ESalary > 1000)
                return "Salary must be between 100 and 1000";
            return "";
        }
    }
}