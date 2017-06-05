using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Entities
{
    public class ShoppingCart
    {
        public string NameOfProduct { set; private get; }
        public decimal Cost { set; private get; }
        public int Quantity { set; private get; }
        


        public decimal CheckOut()
        {
            return Cost * Quantity;
        }
    }
}
