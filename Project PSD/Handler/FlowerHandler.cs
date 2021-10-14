using Project_PSD.Factory;
using Project_PSD.Model;
using Project_PSD.Repository;
using System.Collections.Generic;

namespace Project_PSD.Handler
{
    public class FlowerHandler
    {

        public static MsFlower searchFlower(int id)
        {
            return FlowerRepository.getFlower(id);
        }
        public static void insertFlower(string name, string img, string desc, int typeid, int price)
        {
            MsFlower new_flower = FlowerFactory.createFlower(name, img, desc, typeid, price);

            FlowerRepository.insertFlower(new_flower);
        }

        public static void updateFlower(int id, string name, string img, string desc, int typeid, int price)
        {
            MsFlower new_flower = FlowerFactory.createFlower(name, img, desc, typeid, price);

            FlowerRepository.updateFlower(id, new_flower);
        }

        public static void deleteFlower(int flowerId)
        {
            FlowerRepository.deleteFlower(flowerId);
        }

        public static List<MsFlower> getAllFlower()
        {
            return FlowerRepository.getAllFlower();
        }
    }
}