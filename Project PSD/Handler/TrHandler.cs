using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_PSD.Factory;
using Project_PSD.Model;
using Project_PSD.Repository;
using Project_PSD.View.Pre_Order;

namespace Project_PSD.Handler
{
    public class TrHandler
    {
        public static TrDataSet GetDataset(MsMember member)
        {
            return TrFactory.InsertDataSet(member);
        }
    }
}