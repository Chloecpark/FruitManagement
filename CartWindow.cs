using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Assignment2
{
    public partial class CartWindow : Form
    {
        private Cart cartmodel;
        private Customer c;
        private Fruit f;

        public CartWindow(Cart cart, Customer customer)
        {
            InitializeComponent();
            this.cartmodel = cart;
            this.c = customer;

            LoadCart();
        }

        //Click button to checkout and make payment
        private void checkOutButton_Click(object sender, EventArgs e)
        {
            //prevents checkout process when cart is empty
            if (cartmodel.GetTotalQuantity() == 0)
            {
                // The cart is empty, display a message
                MessageBox.Show("Your cart is empty. Please add items to your cart before checking out.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateBalance(); //after checkout, the user's balance changed
                UpdateQuantity(); //after checkout, fruit's stock changed
            }
        }

        // call cartItem and it's details to print it
        public void LoadCart()
        {
            List<CartItem> items = cartmodel.GetCartItems();

            cartGrid.Rows.Clear();
            foreach (CartItem c in items)
            {
                int rowIndex = cartGrid.Rows.Add(c.Fruit.Id, c.Fruit.Name, c.Fruit.Quantity, c.Fruit.Price, c.Fruit.Organic, c.Fruit.Colour, EachTotalPrice(c.Fruit.Quantity, c.Fruit.Price));
                totalPriceLabel.Text = $"Total Price: $ {cartmodel.GetTotalPrice()} ";
            }
        }

        private double EachTotalPrice(int quantity, double price)
        {
            return quantity * price;
        }

        // go back to CustomerMenu
        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Customer.ResetNextToBeAssignedId();
            new CustomerMenu(c.Id, cartmodel).Show();
        }

        private void CartWindow_Load(object sender, EventArgs e)
        {
            balanceLabel.Text = $"Customer Balance: $ {c.Balance}";
            LoadCart();
        }

        private void UpdateBalance()
        {
            int id = c.Id;
            double balance = c.Balance;
            double totalPrice = cartmodel.GetTotalPrice();

            List<string> lines = new List<string>(File.ReadAllLines("customer.txt"));

            // Find and modify the specific line
            for (int i = 0; i < lines.Count; i++)
            {
                string[] fields = lines[i].Split(',');
                if (fields.Length == 5)
                {
                    int cid = Convert.ToInt32(fields[0]);
                    if (cid == id)
                    {
                        if (c.Balance >= totalPrice)
                        {
                            balance -= totalPrice;

                            fields[4] = balance.ToString();
                            lines[i] = string.Join(",", fields);
                            c.Balance = balance;

                            try
                            {
                                // Write the modified content back to the file
                                File.WriteAllLines("customer.txt", lines);
                                DialogResult result = MessageBox.Show("Order completed. Do you want to view the receipt?", "Order Completed", MessageBoxButtons.OKCancel);
                                if (result == DialogResult.OK)
                                {
                                    // Show the receipt form
                                    Hide();
                                    new Receipt(cartmodel, c).Show();
                                }
                                else
                                {
                                    Hide();
                                    Customer.ResetNextToBeAssignedId();
                                    new CustomerMenu(c.Id).Show();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // Low balance, display an error message
                            DialogResult result = MessageBox.Show("Low Balance.", "Fail to process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (result == DialogResult.OK)
                            {
                                Hide();
                                Customer.ResetNextToBeAssignedId();
                                new CustomerMenu(c.Id).Show();
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void UpdateQuantity()
        {
            foreach (DataGridViewRow row in cartGrid.Rows)
            {
                int id = Convert.ToInt32(row.Cells["fID"].Value);
                f = FruitList.SearchFruit(id);
                int quantity = f.Quantity;
                int selectedQuantity = Convert.ToInt32(row.Cells["quantity"].Value);
                List<string> lines = new List<string>(File.ReadAllLines("fruit.txt"));
                
                // Find and modify the specific line
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (fields.Length == 6)
                    {
                        int fid = Convert.ToInt32(fields[0]);
                        if (fid == id)
                        {
                            if (f.Quantity > 0)
                            {
                                quantity -= selectedQuantity;

                                fields[3] = quantity.ToString();
                                lines[i] = string.Join(",", fields);

                                try
                                {
                                    // Write the modified content back to the file
                                    File.WriteAllLines("fruit.txt", lines);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"An error occurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
