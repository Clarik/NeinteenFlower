using Project_PSD.Handler;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_PSD.Controller
{
    public class FlowerController
    {

        public static MsFlower searchFlower(int id)
        {
            return FlowerHandler.searchFlower(id);
        }


        public static void insertFlower(string name, string img, string desc, string type, string price)
        {

            MsFlowerType typeFlower = FlowerTypeController.getType(type);

            FlowerHandler.insertFlower(name, img, desc, typeFlower.FlowerTypeID, int.Parse(price));
        }

        public static void updateFlower(int id, string name, string img, string desc, string type, string price)
        {
            MsFlowerType typeFlower = FlowerTypeController.getType(type);

            FlowerHandler.updateFlower(id, name, img, desc, typeFlower.FlowerTypeID, int.Parse(price));
        }

        public static void deleteFlower(int flowerId)
        {
            FlowerHandler.deleteFlower(flowerId);
        }

        public static string isFlowerIdAvaible(string id)
        {
            int FId;
            if (int.TryParse(id, out FId) == false)
                return "error";
            FId = int.Parse(id);
            MsFlower f = searchFlower(FId);
            if (f == null)
                return "error";
            return "";
        }

        public static string flowerNameChecker(string name)
        {
            if (name.Length == 0)
                return "Flower name must be filled";
            if (name.Length < 5)
                return "Flower name length minimal 5 character";
            return "";
        }

        public static string flowerImageChecker(string imagePath)
        {
            if (imagePath.Length == 0)
                return "Image Path can't be empty";
            else if (imagePath.EndsWith(".jpg") == false)
                return "Image extensions must end with \".jpg\"";
            return "";
        }

        public static string flowerDescriptionChecker(string description)
        {
            if (description.Length < 50)
                return "Flower description must be longer than 50 character";
            return "";
        }


        public static string flowerPriceChecker(string price)
        {
            int FPrice;
            if (int.TryParse(price, out FPrice) == false)
                return "Price must be an integer";
            FPrice = int.Parse(price);
            if (FPrice < 20 || FPrice > 100)
                return "Price must be between 20 and 100";
            return "";
        }


        public static List<MsFlower> getAllFlower()
        {
            return FlowerHandler.getAllFlower();
        }
        
    }
}