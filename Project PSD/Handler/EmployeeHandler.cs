using Project_PSD.Factory;
using Project_PSD.Model;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_PSD.Handler
{
    public class EmployeeHandler
    {
        public static List<MsEmployee> getAllEmployee()
        {
            return EmployeeRepository.getAllEmployee();
        }

        public static void deleteEmployeeByID(int id)
        {
            EmployeeRepository.deleteEmployeeByID(id);
        }

        public static void insertEmployee(string email, string password, string name, System.DateTime dOB, string gender, string phoneNumber, string address, int salary)
        {
            MsEmployee employee = EmployeeFactory.CreateEmployee(email, password, name, dOB, gender, phoneNumber, address, salary);
            EmployeeRepository.insertEmployee(employee);
        }

        public static MsEmployee searchEmployeeById(int id)
        {
            return EmployeeRepository.getEmployeebyId(id);
        }

        public static MsEmployee searchEmployeeByEmail(string email)
        {
            return EmployeeRepository.getEmployeebyEmail(email);
        }


        public static void updateEmployee(int id, string email, string password, string name, System.DateTime dOB, string gender, string phoneNumber, string address, int salary)
        {
            MsEmployee employee = EmployeeFactory.CreateEmployee(email, password, name, dOB, gender, phoneNumber, address, salary);
            EmployeeRepository.updateEmployee(id, employee);
        }
    }
}