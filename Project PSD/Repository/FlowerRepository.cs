using Project_PSD.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_PSD.Repository
{
    public class FlowerRepository
    {
        public static void insertFlower(MsFlower flower)
        {
            DatabaseEntities db = new DatabaseEntities();

            db.MsFlowers.Add(flower);
            db.SaveChanges();
        }

        public static List<MsFlower> getAllFlower()
        {
            DatabaseEntities db = new DatabaseEntities();
            return db.MsFlowers.ToList();
        }

        public static MsFlower getFlower(int id)
        {
            DatabaseEntities db = new DatabaseEntities();

            MsFlower flower = db.MsFlowers.Find(id);

            return flower;
        }

        public static void deleteFlower(int flowerId)
        {
            DatabaseEntities db = new DatabaseEntities();

            MsFlower flower = db.MsFlowers.Find(flowerId);

            db.MsFlowers.Remove(flower);

            db.SaveChanges();
        }

        public static void updateFlower(int id, MsFlower flower)
        {
            DatabaseEntities db = new DatabaseEntities();

            MsFlower f = db.MsFlowers.Find(id);

            f.FlowerName = flower.FlowerName;
            f.FlowerImage = flower.FlowerImage;
            f.FlowerDescription = flower.FlowerDescription;
            f.FlowerTypeID = flower.FlowerTypeID;
            f.FlowerPrice = flower.FlowerPrice;

            db.SaveChanges();
        }

    }
}