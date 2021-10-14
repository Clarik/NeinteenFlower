using System;
using System.Collections.Generic;
using System.Linq;
using Project_PSD.Controller;
using Project_PSD.Model;
using Project_PSD.Repository;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_PSD.View.Pre_Order
{
    public partial class PreOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.memberSession();
            getFlowerList();
        }

        void getFlowerList()
        {
            List<MsFlower> flowerList = FlowerController.getAllFlower();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Image");
            dt.Columns.Add("Description");
            dt.Columns.Add("Type");
            dt.Columns.Add("Price");


            foreach (MsFlower flower in flowerList)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = flower.FlowerID;
                dr["Name"] = flower.FlowerName;
                dr["Image"] = flower.FlowerImage;
                dr["Description"] = flower.FlowerDescription;
                dr["Type"] = FlowerTypeController.getFlowerTypeName(flower.FlowerTypeID);
                dr["Price"] = flower.FlowerPrice;
                dt.Rows.Add(dr);
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}