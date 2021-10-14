using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repository
{
    public class EmployeeRepository
    {
        public static void insertEmployee(MsEmployee employee)
        {
            DatabaseEntities db = new DatabaseEntities();
            db.MsEmployees.Add(employee);
            db.SaveChanges();
        }

        public static MsEmployee getEmployeebyId(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            MsEmployee employee = db.MsEmployees.Find(id);
            return employee;
        }

        public static MsEmployee getEmployeebyEmail(string email)
        {
            DatabaseEntities db = new DatabaseEntities();
            MsEmployee employee = db.MsEmployees.Where(x => x.EmployeeEmail == email).FirstOrDefault();
            return employee;
        }

        public static List<MsEmployee> getAllEmployee()
        {
            DatabaseEntities db = new DatabaseEntities();
            return db.MsEmployees.ToList();
        }

        public static void deleteEmployeeByID(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            MsEmployee employee = db.MsEmployees.Find(id);
            db.MsEmployees.Remove(employee);
            db.SaveChanges();
        }

        public static void updateEmployee(int id, MsEmployee employee)
        {
            DatabaseEntities db = new DatabaseEntities();
            MsEmployee employee1 = db.MsEmployees.Find(id);
            employee1.EmployeeEmail = employee.EmployeeEmail;
            employee1.EmployeePassword = employee.EmployeePassword;
            employee1.EmployeeName = employee.EmployeeName;
            employee1.EmployeeDOB = employee.EmployeeDOB;
            employee1.EmployeeGender = employee.EmployeeGender;
            employee1.EmployeePhone = employee.EmployeePhone;
            employee1.EmployeeAddress = employee.EmployeeAddress;
            employee1.EmployeeSalary = employee.EmployeeSalary;

            db.SaveChanges();
        }
    }
}