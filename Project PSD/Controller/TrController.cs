using Project_PSD.Handler;
using Project_PSD.Model;
using Project_PSD.View.Pre_Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controller
{
    public class TrController
    {
        public static TrReport Report(MsMember member)
        {
            TrReport report = new TrReport();
            report.SetDataSource(TrHandler.GetDataset(member));
            report.Refresh();
            return report;
        }
    }
}