using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    public class Transaction:Goods
    {
        public int BuyerId { get; set; }
        public int GoodId { get; set; }
        public int Sum { get; set; }
        public bool Status { get; set; }

    }
}
