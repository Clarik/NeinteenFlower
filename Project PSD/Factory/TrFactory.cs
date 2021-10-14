using Project_PSD.Model;
using Project_PSD.Repository;
using Project_PSD.View.Pre_Order;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Project_PSD.Factory
{
    public class TrFactory
    {
        public static TrDataSet InsertDataSet(MsMember member)
        {
            TrDataSet ds = new TrDataSet();
            var TrHeader = ds.TrHeaders;
            var TrMember = ds.MsMembers;
            var TrEmployee = ds.MsEmployees;
            var TrDetail = ds.TrDetails;
            var TrFlower = ds.MsFlowers;
            var TrFlowerType = ds.MsFlowerTypes;
            List<TrHeader> ts = TrRepository.GetHeaderByMemberID(member.MemberID);
            
            for (int i = 0; i < ts.Count; i++)
            {
                TrHeader t = ts[i];

                    var HeaderMember = TrMember.NewRow();
                    HeaderMember["MemberID"] = member.MemberID;
                    HeaderMember["MemberName"] = member.MemberName;
                    TrMember.Rows.Add(HeaderMember);
            
                    var HeaderTr = TrHeader.NewRow();
                    HeaderTr["TransactionID"] = t.TransactionID;
                    HeaderTr["MemberID"] = t.MemberID;
                    HeaderTr["EmployeeID"] = t.EmployeeID;
                    HeaderTr["TransactionDate"] = t.TransactionDate;
                    HeaderTr["DiscountPercent"] = t.DiscountPercent;
                    TrHeader.Rows.Add(HeaderTr);

                    var HeaderEmployee = TrEmployee.NewRow();
                    HeaderEmployee["EmployeeID"] = t.MsEmployee.EmployeeID;
                    HeaderEmployee["EmployeeName"] = t.MsEmployee.EmployeeName;
                    TrEmployee.Rows.Add(HeaderEmployee);

                TrDetail d = TrRepository.GetDetail(t.TransactionID);

                    var DetailTr = TrDetail.NewRow();
                    DetailTr["TransactionID"] = d.TransactionID;
                    DetailTr["FlowerID"] = d.FlowerID;
                    DetailTr["Quantity"] = d.Quantity;
                    DetailTr["SubTotal"] = d.Quantity * d.MsFlower.FlowerPrice;
                    DetailTr["GrandTotal"] = d.Quantity * d.MsFlower.FlowerPrice -
                    (d.Quantity * d.MsFlower.FlowerPrice * (t.DiscountPercent / 100));
                    TrDetail.Rows.Add(DetailTr);

                    var DetailFlower = TrFlower.NewRow();
                    DetailFlower["FlowerID"] = d.MsFlower.FlowerID;
                    DetailFlower["FlowerName"] = d.MsFlower.FlowerName;
                    DetailFlower["FlowerTypeID"] = d.MsFlower.FlowerTypeID;
                    DetailFlower["FlowerPrice"] = d.MsFlower.FlowerPrice;
                    TrFlower.Rows.Add(DetailFlower);

                    var DetailFlowerType = TrFlowerType.NewRow();
                    DetailFlowerType["FlowerTypeID"] = d.MsFlower.MsFlowerType.FlowerTypeID;
                    DetailFlowerType["FlowerTypeName"] = d.MsFlower.MsFlowerType.FlowerTypeName;
                    TrFlowerType.Rows.Add(DetailFlowerType);
            }
            return ds;
        }
    }
}