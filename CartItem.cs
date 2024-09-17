using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class CartItem
    {
        public Fruit Fruit { get; }
        public int Quantity { get; set; }

        public CartItem(Fruit fruit, int quantity)
        {
            Fruit = fruit;
            Quantity = quantity;
        }
    }
}
