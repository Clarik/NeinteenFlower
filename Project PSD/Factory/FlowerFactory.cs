using Project_PSD.Model;

namespace Project_PSD.Factory
{
    public class FlowerFactory
    {
        public static MsFlower createFlower(string name, string img, string desc, int typeid, int price)
        {
            MsFlower new_flower = new MsFlower();

            new_flower.FlowerName = name;
            new_flower.FlowerImage = img;
            new_flower.FlowerDescription = desc;
            new_flower.FlowerTypeID = typeid;
            new_flower.FlowerPrice = price;

            return new_flower;
        }

    }
}