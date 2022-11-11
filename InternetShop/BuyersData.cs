using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class BuyersData
    {
        public static Buyer[] Data()
        {
            Buyer[] Data = new Buyer[200];

            for (int i = 0; i < Data.Length; i++)
                Data[i] = new Buyer();

            Data[0].ID = 1;
            Data[0].Name = "Anton Smith";
            Data[0].PhoneNumber = "066231314";
            Data[0].Balance = 1000;

            Data[1].ID = 2;
            Data[1].Name = "Andrew Nagot";
            Data[1].PhoneNumber = "066232714";
            Data[1].Balance = 300;

            Data[2].ID = 2;
            Data[2].Name = "Anna Gold";
            Data[2].PhoneNumber = "066232514";
            Data[2].Balance = 500;

            return Data;
        }
    }
}
