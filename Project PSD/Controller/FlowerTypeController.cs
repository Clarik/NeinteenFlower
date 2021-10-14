using Project_PSD.Handler;
using Project_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controller
{
    public class FlowerTypeController
    {
        public static MsFlowerType getType(string type)
        {
            return FlowerTypeHandler.getType(type);    
        }
        public static List<string> getFlowerType()
        {
            return FlowerTypeHandler.getFlowerType();
        }

        public static String getFlowerTypeName(int id)
        {
            return FlowerTypeHandler.getFlowerTypeName(id);
        }
    }
}