using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Cart
    {
        private List<CartItem> items;
        private int id;
        public Cart(int id)
        {
            this.id = id;
            items = new List<CartItem>();
        }

        public void AddToCart(Fruit fruit, int quantity)
        {
            
            // Check if the same fruit is already in the cart
            CartItem existingItem = null;

            foreach (CartItem item in items)
            {
                if (item.Fruit.Id == fruit.Id)
                {
                    existingItem = item;
                    break;
                }
            }
            if (existingItem != null)
            {
                existingItem.Quantity += fruit.Quantity;
            }
            else
            {
                //if selected fruit is not in cart, add to CartItem
                items.Add(new CartItem(fruit, quantity));
            }
        }

        public List<CartItem> GetCartItems()
        {
            return items;
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (CartItem item in items)
            {
                total += item.Fruit.Quantity * item.Fruit.Price;
            }
            return total;
        }

        public int GetTotalQuantity()
        {
            int total = 0;
            foreach (CartItem item in items)
            {
                total += item.Fruit.Quantity;
            }
            return total;
        }
    }
}
