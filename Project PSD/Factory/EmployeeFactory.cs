using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Factory
{
    public class EmployeeFactory
    {
        public static MsEmployee CreateEmployee(string email, string password, string name, System.DateTime dOB, string gender, string phoneNumber, string address, int salary)
        {
            MsEmployee new_employee = new MsEmployee();
            new_employee.EmployeeEmail = email;
            new_employee.EmployeePassword = password;
            new_employee.EmployeeName = name;
            new_employee.EmployeeDOB = dOB;
            new_employee.EmployeeGender = gender;
            new_employee.EmployeePhone = phoneNumber;
            new_employee.EmployeeAddress = address;
            new_employee.EmployeeSalary = salary;
            return new_employee;
        }
    }
}