using System;
using Project_PSD.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Project_PSD.Repository
{
    public class TrRepository
    {
        public static void Order (int quan, MsFlower flower)
        {
            MsMember member = (MsMember)HttpContext.Current.Session["user"];
            CreateHeader(member,quan,flower);
        }
        
        private static void CreateDetail(int id,int quan, MsFlower flower)
        {
            DatabaseEntities db = new DatabaseEntities();

            TrDetail detail = new TrDetail();
            detail.TransactionID = id;
            detail.FlowerID = flower.FlowerID;
            detail.Quantity = quan;

            db.TrDetails.Add(detail);
            db.SaveChanges();
        }

        private static void CreateHeader(MsMember member, int quan, MsFlower flower)
        {
            DatabaseEntities db = new DatabaseEntities();

            TrHeader head = new TrHeader();
            head.MemberID = member.MemberID;
            head.EmployeeID = 2;
            head.TransactionDate = DateTime.Now;
            head.DiscountPercent = 0;

            db.TrHeaders.Add(head);
            db.SaveChanges();
            CreateDetail(head.TransactionID, quan, flower);
        }

        public static TrDetail GetDetail(int TrID)
        {
            DatabaseEntities db = new DatabaseEntities();
            TrDetail detail = db.TrDetails.Where(x => x.TransactionID == TrID).FirstOrDefault();
            return detail;
        }

        public static List<TrHeader> GetHeaderByMemberID(int id)
        {
            DatabaseEntities db = new DatabaseEntities();

            List<TrHeader> head = db.TrHeaders.Where(x => x.MemberID == id).ToList();

            return head;
        }
    }
}