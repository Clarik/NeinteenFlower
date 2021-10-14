using System;
using Project_PSD.Controller;
using System.Collections.Generic;
using System.Linq;
using Project_PSD.Model;
using Project_PSD.Repository;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Project_PSD.View.Pre_Order
{
    public partial class OrderFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.memberSession();
            OrderedFlower();
        }

        void OrderedFlower()
        {
            int id = int.Parse(Request.QueryString["id"]);
            MsFlower flower = FlowerController.searchFlower(id);

            Fid.Text = flower.FlowerID.ToString();
            Fname.Text = flower.FlowerName;
            Ftype.Text = FlowerTypeController.getFlowerTypeName(flower.FlowerTypeID);
            Fprice.Text = flower.FlowerPrice.ToString();
        }

        protected void preOrder_Click(object sender, EventArgs e)
        {
            int quan = int.Parse(Fquan.Text);
            if (quan < 1)
            {
                Response.Redirect("PreOrder.aspx");
            }
            else
            {
                int id = int.Parse(Request.QueryString["id"]);
                MsFlower flower = FlowerController.searchFlower(id);
                TrRepository.Order(quan, flower);
                Response.Redirect("ViewTr.aspx");
            }
        }
    }
}