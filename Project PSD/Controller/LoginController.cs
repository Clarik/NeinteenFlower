using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;

namespace Project_PSD.Controller
{
    public class LoginController
    {
        public static string login(string email, string password, bool rememberMe)
        {
            if (EmployeeController.emailChecker(email).Equals("Email is taken"))
            {
                MsEmployee employee = EmployeeController.searchEmployee(email);
                if (!password.Equals(employee.EmployeePassword))
                    return "Wrong password";
                employeeSession(employee);
                if (rememberMe)
                    addCookie(email, password);
                gotoHomePage();
                return "";
            }
            else if (MemberController.MemberEmailChecker(email).Equals("Email is taken"))
            {
                MsMember member = MemberController.searchMember(email);
                if (!password.Equals(member.MemberPassword))
                    return "Wrong password";
                memberSession(member);
                if (rememberMe)
                    addCookie(email, password);
                else
                    destroyCookie();
                gotoHomePage();
                return "";
            }
            return "Email doesn't exists in database please do register first!";
        }


        public static void gotoHomePage()
        {
            var home = HttpContext.Current.Request.Url.AbsolutePath == "/View/HomePage/HomePage.aspx";
            var login = HttpContext.Current.Request.Url.AbsolutePath == "/View/HomePage/LoginPage.aspx";
            var register = HttpContext.Current.Request.Url.AbsolutePath == "/View/HomePage/RegisterPage.aspx";
            var forgot = HttpContext.Current.Request.Url.AbsolutePath == "/View/HomePage/ForgotPasswordPage.aspx";
            if ((home || login || register || forgot) == false || isSessionAvaible() == true)
                HttpContext.Current.Response.Redirect("/View/HomePage/HomePage.aspx");
        }

        public static void addCookie(string email, string password)
        {
            HttpCookie cookie = new HttpCookie("currentUser");
            cookie.Value = email;
            cookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }


        public static void employeeSession(MsEmployee user)
        {
            
            HttpContext.Current.Session.Add("user", user);
            HttpContext.Current.Session["roles"] = user.EmployeeEmail.Equals("admin") ? "admin" : "employee";
        }

        public static void memberSession(MsMember user)
        {
            HttpContext.Current.Session.Add("user", user);
            HttpContext.Current.Session["roles"] = "member";
        }
        
        public static void isCookieOrSessionAvaible()
        {
            if (isSessionAvaible() == false && isCookieAvaible() == false)
                gotoHomePage();
        }

        public static bool isSessionAvaible()
        {
            var session = HttpContext.Current.Session["user"];
            if (session == null)
                return false;
            return true;
        }

        public static bool isCookieAvaible()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["currentUser"];
            if (cookie != null)
            {
                System.Diagnostics.Debug.WriteLine("Ada Cookie");
                string email = cookie.Value;
                if (EmployeeController.emailChecker(email).Equals("Email is taken"))
                {
                    MsEmployee employee = EmployeeController.searchEmployee(email);
                    employeeSession(employee);
                }
                else if (MemberController.MemberEmailChecker(email).Equals("Email is taken"))
                {
                    MsMember member = MemberController.searchMember(email);
                    memberSession(member);
                }
                return true;
            }
            return false;
        }

        public static void logout()
        {
            destroyCookie();
            destroySession();
            
        }

        static void destroySession()
        {
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Session.Abandon();
        }

        static void destroyCookie()
        {
            if (isCookieAvaible())
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies["currentUser"];
                cookie.Expires = DateTime.Now.AddDays(-10);
                HttpContext.Current.Response.Cookies.Remove("currentUser");
                HttpContext.Current.Response.SetCookie(cookie);
            }
        }


        public static void adminSession()
        {
            if (!HttpContext.Current.Session["roles"].Equals("admin"))
                LoginController.gotoHomePage();
        }

        public static void employeeSession()
        {
            if (!HttpContext.Current.Session["roles"].Equals("employee"))
                LoginController.gotoHomePage();
        }

        public static void memberSession()
        {
            if (!HttpContext.Current.Session["roles"].Equals("member"))
                LoginController.gotoHomePage();
        }
    }
}