using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal class Program
    {

        private static Goods GoodGet(int id)
        {
            return GoodsData.Data()[id];
        }

        private static Buyer BuyerGet(int id)
        {
            return BuyersData.Data()[id];
        }

     

        private static void CreateProduct(int id)
        {
            if (id < GoodsData.Data().Length && id > 0) 
            {
                Console.WriteLine("Enter Quantity");
                GoodGet(id).Quantity = int.Parse(Console.ReadLine());
                GoodGet(id).ID = id;
                Console.WriteLine("Enter Product's name");
                GoodGet(id).Name = Console.ReadLine();
                Console.WriteLine("Enter price");
                GoodGet(id).Price = int.Parse(Console.ReadLine());
            }
        }

        private static void RegisterBuyer(int id)
        {
            if (id < BuyersData.Data().Length && id > 0)
            {
                Console.WriteLine("Enter Name");
                BuyerGet(id).Name = Console.ReadLine();
                BuyerGet(id).ID = id;
                Console.WriteLine("Enter balance");
                BuyerGet(id).Balance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Phone Number");
                BuyerGet(id).PhoneNumber = Console.ReadLine();
            }
        }

        private static void ShowAllGoods()
        {
            for (int i = 0; i < GoodsData.Data().Length; i++)
            {
                if (GoodGet(i).Name!= null && GoodGet(i).Quantity != 0)
                    Console.WriteLine($"ID {GoodGet(i).ID}, Name {GoodGet(i).Name}, Price {GoodGet(i).Price}, Quantity {GoodGet(i).Quantity}");
            }
        }

        private static void ShowAllBuyers()
        {
            for (int i = 0; i < BuyersData.Data().Length; i++)
            {
                if (BuyerGet(i).Name != null)
                    Console.WriteLine($"ID {BuyerGet(i).ID}, Name {BuyerGet(i).Name}, Phone Number {BuyerGet(i).PhoneNumber}, Balance {BuyerGet(i).Balance}$");
            }
        }


        static void Main(string[] args)
        {
            int NumberInput;
            do 
            {
                NumberInput = int.Parse(Console.ReadLine());
                switch (NumberInput)
                {
                    case 1:
                        int ProductId = int.Parse(Console.ReadLine());
                        CreateProduct(ProductId);
                        break;

                    case 2:
                        ShowAllGoods();
                        break;

                    case 3:
                        int BuyerId = int.Parse(Console.ReadLine());
                        RegisterBuyer(BuyerId);
                        break;
                    case 4:
                        ShowAllBuyers();
                        break;
                    case 5:
                        ProductId = int.Parse(Console.ReadLine());
                        BuyerId = int.Parse(Console.ReadLine());
                        int quant = int.Parse(Console.ReadLine());
                        Processing.TransactionCreate(BuyerId, ProductId, quant);
                        break;
                }

            } while (NumberInput!=0);
        }
    }
}