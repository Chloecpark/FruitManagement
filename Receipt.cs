using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Assignment2
{
    public partial class Receipt : Form
    {
        Cart c;
        Customer cus;
        List<string> lines;
        public Receipt(Cart cart, Customer customer)
        {
            InitializeComponent();
            this.cus = customer;
            this.c = cart;
        }

        // print customer's purchase detail
        private void Receipt_Load(object sender, EventArgs e)
        {
            // to get issueDate
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");

            issueDateLabel.Text = $"Issue Date: {currentDate}";
            nameLabel.Text = $"Customer Name: {cus.FName} {cus.LName}";
            balanceLabel.Text = $"Balance: $ {cus.Balance}";
            totalPriceLabel.Text = $"Total Price: $ {c.GetTotalPrice()}";
            descriptionLabel.Text = string.Join("\n", GetLine());
        }


        private List<string> GetLine()
        {
            lines = new List<string>();

            foreach (CartItem item in c.GetCartItems())
            {
                string fruitName = item.Fruit.Name;
                int quantity = item.Fruit.Quantity;
                double price = item.Fruit.Price;
                double total = quantity * price;

                string line = $"{fruitName,-20} {quantity,-23} {price,-23} {total,-16}";
                lines.Add(line);

            }
            lines.Add(new string("========================================="));
            return lines;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Customer.ResetNextToBeAssignedId();
            new CustomerMenu(cus.Id).Show();
        }
    }
}
