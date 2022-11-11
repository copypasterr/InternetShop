using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InternetShop
{
    public class GoodsData
    {
        public static Goods[] Data()
        {
            Goods[] Data = new Goods[200];

            for (int i = 0; i < Data.Length; i++)
                Data[i] = new Goods();


            Data[0].ID = 1;
            Data[0].Name = "Laptop";
            Data[0].Price = 1200;
            Data[0].Quantity = 10;

            Data[1].ID = 2;
            Data[1].Name = "Hair dryer";
            Data[1].Price = 123;
            Data[1].Quantity = 20;

            Data[2].ID = 3;
            Data[2].Name = "TV-set";
            Data[2].Price = 123;
            Data[2].Quantity = 20;



            return Data; 
        }
    }
}
