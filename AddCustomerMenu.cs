using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class AddCustomerMenu : Form
    {
        int nextId;
        int id;
        Admin a;
        public AddCustomerMenu(int id)
        {
            InitializeComponent();
            nextId = Customer.NextToBeAssignedId;
            this.id = id;
        }

        private void AddCustomerMenu_Load(object sender, EventArgs e)
        {
            int rowIndex = CustomerGrid.Rows.Add(nextId, null, null, null, null, null);
            CustomerGrid.Rows[rowIndex].Cells["cAddButton"].Value = "Add";
        }

        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == CustomerGrid.Columns["cAddButton"].Index)
                {
                    string fName = CustomerGrid.Rows[e.RowIndex].Cells["fName"].Value.ToString();
                    string lName = CustomerGrid.Rows[e.RowIndex].Cells["lName"].Value.ToString();
                    string dob = CustomerGrid.Rows[e.RowIndex].Cells["dob"].Value.ToString();
                    double balance = Convert.ToDouble(CustomerGrid.Rows[e.RowIndex].Cells["balance"].Value);
                    string password = CustomerGrid.Rows[e.RowIndex].Cells["password"].Value.ToString();
                    Customer newCustomer = new Customer(fName, lName, dob, balance);
                    newCustomer.Id = nextId;
                    try
                    {
                        using (StreamWriter writer = new StreamWriter("customer.txt", true)) //append the customer's details to the "customer.txt" file
                        {
                            string customerDetails = $"{newCustomer.Id},{newCustomer.FName},{newCustomer.LName},{newCustomer.Dob},{newCustomer.Balance}";
                            writer.WriteLine(customerDetails);
                            writer.Close();
                        }
                        using (StreamWriter writer = new StreamWriter("login.txt", true)) //append the customer's login credentials to the "login.txt" file
                        {
                            string loginDetails = $"{newCustomer.Id},{password}";
                            writer.WriteLine(loginDetails);
                            writer.Close();

                        }
                        Customer.ResetNextToBeAssignedId();
                        Admin.ResetNextToBeAssignedId();
                        if (MessageBox.Show("New customer added successfully. Click OK to return to admin menu.", "Success") == DialogResult.OK)
                        {
                            Hide();
                            new AdminMenu(id, true).Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Admin.ResetNextToBeAssignedId();
            new AdminMenu(AdminList.SearchAdmin(id).Id, true).Show();
        }
    }
}
