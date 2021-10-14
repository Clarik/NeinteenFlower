using Project_PSD.Controller;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.Pre_Order
{
    public partial class ViewTr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsMember member = (MsMember)HttpContext.Current.Session["user"];
            TrReport report = TrController.Report(member);
            ReportViewer.ReportSource = report;
        }
    }
}