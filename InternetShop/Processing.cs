using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Processing
    {
        public static Transaction TransactionCreate(int BuyerID, int GoodsID, int Quant)
        {
            Transaction Trans1 = new Transaction()
            {
                BuyerId = BuyerID,
                GoodId = GoodsID,
                Quantity = Quant,
                Sum = Quant * GoodsData.Data()[GoodsID].Price
            };

            if (BuyersData.Data()[BuyerID].Balance < Trans1.Sum && GoodsData.Data()[GoodsID].Quantity < Quant)
            {
                Console.WriteLine("The transaction failed");
                Trans1.Status = false;
            }

            else
            {
                Console.WriteLine("Transaction Success");
                int GoodsRest = GoodsData.Data()[GoodsID].Quantity - Quant;
                int Remainder = BuyersData.Data()[BuyerID].Balance - Trans1.Sum;

                BuyersData.Data()[BuyerID].Balance = Remainder;
                GoodsData.Data()[GoodsID].Quantity = GoodsRest;
                Trans1.Status = true;
            }

            return Trans1;
        }
    }
}
