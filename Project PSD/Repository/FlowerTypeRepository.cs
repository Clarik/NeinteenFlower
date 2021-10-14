using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repository
{
    public class FlowerTypeRepository
    {
        public static MsFlowerType getTypeID(string type)
        {
            DatabaseEntities db = new DatabaseEntities();
            MsFlowerType typeFlower = db.MsFlowerTypes.Where(x => x.FlowerTypeName == type).FirstOrDefault();

            return typeFlower;
        }

        public static List<string> getFlowerType()
        {
            DatabaseEntities db = new DatabaseEntities();
            List<string> type = db.MsFlowerTypes.Select(x => x.FlowerTypeName).ToList();
            return type;
        }

        public static String getFlowerTypeName(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            MsFlowerType type = (from x in db.MsFlowerTypes where x.FlowerTypeID == id select x).FirstOrDefault();
            return type.FlowerTypeName;
        }
    }
}