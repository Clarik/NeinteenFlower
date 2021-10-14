using Project_PSD.Model;
using Project_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Handler
{
    public class FlowerTypeHandler
    {
        public static MsFlowerType getType(string type)
        {
            return FlowerTypeRepository.getTypeID(type);
        }

        public static List<string> getFlowerType()
        {
            return FlowerTypeRepository.getFlowerType();
        }

        public static String getFlowerTypeName(int id)
        {
            return FlowerTypeRepository.getFlowerTypeName(id);
        }
    }
}