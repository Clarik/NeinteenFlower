using Project_PSD.Controller;
using Project_PSD.Model;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Project_PSD.View
{
    public partial class ViewFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginController.isCookieOrSessionAvaible();
            LoginController.employeeSession();
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

            Grid_View.DataSource = dt;
            Grid_View.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (Request.QueryString["id"] == null) ;
            else if (!int.TryParse(Request.QueryString["id"], out id)) ;
            else
            {
                id = int.Parse(Request.QueryString["id"]);
                deleteFlower(id);
            }
            backToPage();
        }

        void deleteFlower(int id)
        {
            FlowerController.deleteFlower(id);
        }


        void backToPage()
        {
            Response.Redirect("ViewFlower.aspx");
        }

        protected void Grid_View_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertFlower.aspx");
        }
    }
}