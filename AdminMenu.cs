using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class AdminMenu : Form
    {
        private AdminList aList = new AdminList();
        private CustomerList cList = new CustomerList();
        private FruitList fList = new FruitList();
        private int id;
        private bool isDeletedCustomers;
        private Admin a;
        public AdminMenu(int id)
        {
            InitializeComponent();
            this.id = id;
            aList.LoadAdmin("admin.txt");
            cList.LoadCustomer("customer.txt");
            fList.LoadFruit("fruit.txt");
            a = AdminList.SearchAdmin(id);
        }

        public AdminMenu(int id, bool isDeletedCustomers) //constructor for displaying customer tab after deleting customer
        {
            InitializeComponent();
            this.id = id;
            this.isDeletedCustomers = isDeletedCustomers;
            aList.LoadAdmin("admin.txt");
            cList.LoadCustomer("customer.txt");
            fList.LoadFruit("fruit.txt");
            a = AdminList.SearchAdmin(id);
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            if (isDeletedCustomers)
            {
                UserNameLabel.Text = $"Currently logged in as: {a.FName} {a.LName}";
                addFButton.Hide();
                deleteFButton.Hide();
                inventoryGrid.Hide();
                SearchFButton.Hide();
                SearchFTextBox.Hide();
                LoadCustomer();
            }
            else
            {
                UserNameLabel.Text = $"Currently logged in as: {a.FName} {a.LName}";
                addCButton.Hide();
                deleteCButton.Hide();
                CustomerGrid.Hide();
                SearchCButton.Hide();
                SearchCTextBox.Hide();
                LoadInventory();
            }
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            CustomerGrid.Hide();
            inventoryGrid.Show();

            addCButton.Hide();
            addFButton.Show();

            deleteCButton.Hide();
            deleteFButton.Show();

            SearchCButton.Hide();
            SearchFButton.Show();

            SearchCTextBox.Hide();
            SearchFTextBox.Show();
            LoadInventory();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            inventoryGrid.Hide();
            CustomerGrid.Show();

            addFButton.Hide();
            addCButton.Show();

            deleteFButton.Hide();
            deleteCButton.Show();

            SearchFButton.Hide();
            SearchCButton.Show();

            SearchFTextBox.Hide();
            SearchCTextBox.Show();
            LoadCustomer();

        }

        private void LoadInventory()
        {
            List<Fruit> frList = null;
            Fruit.ResetNextToBeAssignedId();
            frList = fList.ListFruit("fruit.txt");
            inventoryGrid.Rows.Clear();

            foreach (Fruit f in frList)
            {
                bool check = false;
                int rowIndex = inventoryGrid.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                string buttonText = "Update";
                inventoryGrid.Rows[rowIndex].Cells["fEditButton"].Value = buttonText;
            }

        }
        private void LoadCustomer()
        {
            List<Customer> cuList = null;
            Customer.ResetNextToBeAssignedId();
            cuList = cList.ListCustomer("customer.txt");
            CustomerGrid.Rows.Clear();

            foreach (Customer c in cuList)
            {
                bool check = false;

                int rowIndex = CustomerGrid.Rows.Add(check, c.Id, c.FName, c.LName, c.Dob, c.Balance);
                string buttonText = "Update";
                CustomerGrid.Rows[rowIndex].Cells["cEditButton"].Value = buttonText;
            }

        }
        //added
        private void inventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == inventoryGrid.Columns["fEditButton"].Index && e.RowIndex >= 0)
                {
                    // Get the values from the selected row
                    int id = Convert.ToInt32(inventoryGrid.Rows[e.RowIndex].Cells["fruitId"].Value);
                    string name = inventoryGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    double price = Convert.ToDouble(inventoryGrid.Rows[e.RowIndex].Cells["price"].Value);
                    int quantity = Convert.ToInt32(inventoryGrid.Rows[e.RowIndex].Cells["stock"].Value);
                    bool organic = Convert.ToBoolean(inventoryGrid.Rows[e.RowIndex].Cells["organic"].Value);
                    string colour = inventoryGrid.Rows[e.RowIndex].Cells["colour"].Value.ToString();

                    // Read the existing content of the file
                    List<string> lines = new List<string>(File.ReadAllLines("fruit.txt"));

                    // Find and modify the specific line
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        if (fields.Length == 6)
                        {
                            int fId = Convert.ToInt32(fields[0]);
                            if (fId == id)
                            {
                                // Check if the data has actually changed
                                if (fields[1] != name || fields[2] != price.ToString() || fields[3] != quantity.ToString() || fields[4] != organic.ToString() || fields[5] != colour)
                                {
                                    // Update the values in the fields array
                                    fields[1] = name;
                                    fields[2] = price.ToString();
                                    fields[3] = quantity.ToString();
                                    fields[4] = organic.ToString();
                                    fields[5] = colour;

                                    // Join the fields back into a single string and replace the line
                                    lines[i] = string.Join(',', fields);

                                    // Data has changed, display the success message
                                    try
                                    {
                                        // Write the modified content back to the file
                                        File.WriteAllLines("fruit.txt", lines);
                                        MessageBox.Show("File updated successfully.", "Success");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("An error occurred: " + ex.Message);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No value changed in this row!\nPlease press the corresponding update button on the row that you are modifying.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                break;
                            }
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Please enter valid input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //added
        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == CustomerGrid.Columns["cEditButton"].Index && e.RowIndex >= 0)
                {
                    // Get the values from the selected row
                    int id = Convert.ToInt32(CustomerGrid.Rows[e.RowIndex].Cells["cID"].Value);
                    string fName = CustomerGrid.Rows[e.RowIndex].Cells["fName"].Value.ToString();
                    string lName = CustomerGrid.Rows[e.RowIndex].Cells["lName"].Value.ToString();
                    string dob = CustomerGrid.Rows[e.RowIndex].Cells["dob"].Value.ToString();
                    double balance = Convert.ToDouble(CustomerGrid.Rows[e.RowIndex].Cells["balance"].Value);
                    // Read the existing content of the file
                    List<string> lines = new List<string>(File.ReadAllLines("customer.txt"));

                    // Find and modify the specific line
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        if (fields.Length == 5)
                        {
                            int fId = Convert.ToInt32(fields[0]);
                            if (fId == id)
                            {
                                if (fields[1] != fName || fields[2] != lName || fields[3] != dob || fields[4] != balance.ToString())
                                {
                                    // Update the values in the fields array
                                    fields[1] = fName;
                                    fields[2] = lName;
                                    fields[3] = dob;
                                    fields[4] = balance.ToString();

                                    // Join the fields back into a single string and replace the line
                                    lines[i] = string.Join(",", fields);

                                    try
                                    {
                                        // Write the modified content back to the file
                                        File.WriteAllLines("customer.txt", lines);
                                        MessageBox.Show("File updated successfully.", "Success");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"An error occurred: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No value changed in this row!\nPlease press the corresponding update button on the row that you are modifying.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LogIn().Show();
            Admin.ResetNextToBeAssignedId();
            Customer.ResetNextToBeAssignedId();
            Fruit.ResetNextToBeAssignedId();
        }

        private void addFButton_Click(object sender, EventArgs e)
        {
            Hide();
            new AddFruitMenu(id).Show();
        }

        private void deleteCButton_Click(object sender, EventArgs e)
        {
            bool isDeleted = false;
            if (MessageBox.Show("Are you sure you want to delete the selected records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<string> cLines = new List<string>(File.ReadAllLines("customer.txt"));
                List<string> lLines = new List<string>(File.ReadAllLines("login.txt"));

                for (int i = CustomerGrid.RowCount - 1; i >= 0; i--)
                {
                    if (Convert.ToBoolean(CustomerGrid.Rows[i].Cells["check"].Value))
                    {
                        isDeleted = true;
                        //finds the customer id to be deleted
                        int cIDToDel = Convert.ToInt32(CustomerGrid.Rows[i].Cells["cID"].Value);

                        // Use a lambda expression to find the index of the customer ID 
                        int index = cLines.FindIndex(line => line.StartsWith(cIDToDel.ToString()));
                        if (index >= 0)
                        {
                            cLines.RemoveAt(index);
                            lLines.RemoveAll(line => line.StartsWith(cIDToDel.ToString()));
                        }
                    }
                    if (isDeleted == false)
                    {
                        MessageBox.Show("Oops, you have not selected any rows to be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                File.WriteAllLines("customer.txt", cLines);
                File.WriteAllLines("login.txt", lLines);

                Hide();
                Admin.ResetNextToBeAssignedId();
                new AdminMenu(id, true).Show();
            }
        }

        private void addCButton_Click(object sender, EventArgs e)
        {
            Hide();
            new AddCustomerMenu(id).Show();
        }

        private void deleteFButton_Click(object sender, EventArgs e)
        {
            bool isDeleted = false;
            if (MessageBox.Show("Are you sure you want to delete the selected records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<string> lines = new List<string>(File.ReadAllLines("fruit.txt"));

                for (int i = inventoryGrid.RowCount - 1; i >= 0; i--)
                {
                    if (Convert.ToBoolean(inventoryGrid.Rows[i].Cells["checkFruit"].Value))
                    {
                        isDeleted = true;
                        //finds the fruit id to be deleted
                        int fIDToDel = Convert.ToInt32(inventoryGrid.Rows[i].Cells["fruitId"].Value);

                        // Use a lambda expression to find the index of the fruit ID
                        int index = lines.FindIndex(line => line.StartsWith(fIDToDel.ToString()));
                        if (index >= 0)
                        {
                            lines.RemoveAt(index);
                        }
                    }
                    if (isDeleted == false)
                    {
                        MessageBox.Show("Oops, you have not selected any rows to be deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                File.WriteAllLines("fruit.txt", lines);

                Hide();
                Admin.ResetNextToBeAssignedId();
                new AdminMenu(id).Show();
            }
        }

        private void SearchCButton_Click(object sender, EventArgs e)
        {
            CustomerGrid.Rows.Clear();
            List<Customer> cList = CustomerList.SearchCustomer(SearchCTextBox.Text);
            if (cList != null)
            {
                bool check = false;
                string buttonText = "Update";
                addCButton.Hide();
                foreach (Customer c in cList)
                {
                    int rowIndex = CustomerGrid.Rows.Add(check, c.Id, c.FName, c.LName, c.Dob, c.Balance);
                    CustomerGrid.Rows[rowIndex].Cells["cEditButton"].Value = buttonText;
                }
            }
            else
            {
                MessageBox.Show($"There are no customers with the name: {SearchCTextBox.Text}!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchFButton_Click(object sender, EventArgs e)
        {
            inventoryGrid.Rows.Clear();
            List<Fruit> fList = FruitList.SearchFruit(SearchFTextBox.Text);
            if (fList != null)
            {
                bool check = false;
                string buttonText = "Update";
                addFButton.Hide();
                foreach (Fruit f in fList)
                {
                    int rowIndex = inventoryGrid.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                    inventoryGrid.Rows[rowIndex].Cells["fEditButton"].Value = buttonText;
                }
            }
            else
            {
                MessageBox.Show($"There are no fruits with the name: {SearchFTextBox.Text}!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Fruit.ResetNextToBeAssignedId();
            List<Fruit> frList = fList.ListFruit("fruit.txt");
            Customer.ResetNextToBeAssignedId();
            List<Customer> customerList = cList.ListCustomer("customer.txt");
            double totalInventoryValue = 0.0;
            foreach (Fruit f in frList)
            {
                totalInventoryValue += f.Price * f.Quantity;
            }
            new AdminReport(totalInventoryValue, customerList.Count).Show();
        }

        private void SearchFTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter key is pressed, trigger the login button's click event
            {
                SearchFButton_Click(sender, e);
            }
        }

        private void SearchCTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter key is pressed, trigger the login button's click event
            {
                SearchCButton_Click(sender, e);
            }
        }

        private void organicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView
            inventoryGrid.Rows.Clear();

            // Load the list of fruits from the file
            List<Fruit> frList = fList.ListFruit("fruit.txt");

            // Filter and display only organic fruits
            foreach (Fruit f in frList)
            {
                if (f.Organic)
                {
                    bool check = false;
                    int rowIndex = inventoryGrid.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                    string buttonText = "Update";
                    inventoryGrid.Rows[rowIndex].Cells["fEditButton"].Value = buttonText;

                }
            }
        }

        private void nonOrganicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventoryGrid.Rows.Clear();

            // Load the list of fruits from the file
            List<Fruit> frList = fList.ListFruit("fruit.txt");

            // Filter and display only organic fruits
            foreach (Fruit f in frList)
            {
                if (!f.Organic)
                {
                    bool check = false;
                    int rowIndex = inventoryGrid.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                    string buttonText = "Update";
                    inventoryGrid.Rows[rowIndex].Cells["fEditButton"].Value = buttonText;

                }
            }
        }
    }
}
