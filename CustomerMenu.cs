using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Assignment2
{
    public partial class CustomerMenu : Form
    {
        private CustomerList cList = new CustomerList();
        private FruitList fList = new FruitList();
        private int id;
        private Customer c;
        private Cart cart;

        public CustomerMenu(int id)
        {
            InitializeComponent();
            this.id = id;
            cList.LoadCustomer("customer.txt");
            fList.LoadFruit("fruit.txt");
            c = CustomerList.SearchCustomer(id);
            fruitTable.DataError += FruitTable_DataError;
            fruitTable.CellValueChanged += new DataGridViewCellEventHandler(fruitTable_CellValueChanged);
            cart = new Cart(id);
            LoadInventory();
        }

        public CustomerMenu(int id, Cart cart)
        {
            InitializeComponent();
            this.id = id;
            cList.LoadCustomer("customer.txt");
            fList.LoadFruit("fruit.txt");
            c = CustomerList.SearchCustomer(id);
            fruitTable.DataError += FruitTable_DataError;
            fruitTable.CellValueChanged += new DataGridViewCellEventHandler(fruitTable_CellValueChanged);
            this.cart = cart;
            LoadInventoryAfterAddingToCart();
        }

        // Go back to logIn menu
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LogIn().Show();
            Admin.ResetNextToBeAssignedId();
            Customer.ResetNextToBeAssignedId();
            Fruit.ResetNextToBeAssignedId();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = $"Currently logged in as: {c.FName} {c.LName}";
            //make sure that user cannot add fruit when quantity is not selected
            for (int i = 0; i < fruitTable.RowCount; i++)
                fruitTable.Rows[i].Cells["check"].ReadOnly = true;
        }

        private void fruitTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == fruitTable.Columns["check"].Index)
            {
                DataGridViewCheckBoxCell checkboxCell = fruitTable.Rows[e.RowIndex].Cells["check"] as DataGridViewCheckBoxCell;

                if (checkboxCell.Value != null)
                {
                    bool isChecked = (bool)checkboxCell.Value;
                    checkboxCell.Value = !isChecked;
                    fruitTable.Invalidate();
                }
            }
        }

        //for making sure user enter quantity before selecting an item
        private void fruitTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == fruitTable.Columns["quantity"].Index)
            {
                // Check if the quantity column has been edited
                int rowIndex = e.RowIndex;
                DataGridViewCell quantityCell = (DataGridViewComboBoxCell)fruitTable.Rows[rowIndex].Cells["quantity"];
                if (Convert.ToInt32(quantityCell.Value) > 0)
                {
                    // Quantity has been entered, so set the check column as editable
                    fruitTable.Rows[rowIndex].Cells["check"].ReadOnly = false;
                }
                else
                {
                    // Quantity is empty, so set the check column as read-only
                    fruitTable.Rows[rowIndex].Cells["check"].ReadOnly = true;
                }
            }
        }


        private void AddToButton_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            for (int i = 0; i < fruitTable.RowCount; i++)
            {
                if ((bool)fruitTable.Rows[i].Cells["check"].Value)
                {
                    // Add the selected fruit to the cart
                    int id = Convert.ToInt32(fruitTable.Rows[i].Cells["FruitId"].Value);
                    string name = fruitTable.Rows[i].Cells["name"].Value.ToString(); // Assuming "Name" is the column name for fruit name
                    double price = Convert.ToDouble(fruitTable.Rows[i].Cells["price"].Value); // Assuming "Price" is the column name for price
                    int quantity = Convert.ToInt32(fruitTable.Rows[i].Cells["quantity"].Value); // Assuming "Quantity" is the column name for quantity
                    bool organic = Convert.ToBoolean(fruitTable.Rows[i].Cells["organic"].Value);
                    string colour = fruitTable.Rows[i].Cells["colour"].Value.ToString();
                    if (quantity == 0)
                    {
                        MessageBox.Show("Oops, you have not selected a quantity for the fruit to be added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        DialogResult confirmation = MessageBox.Show($"Are you sure you want to add these {name}(s)?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmation == DialogResult.Yes)
                        {
                            isAdded = true;
                            Fruit fruit = new Fruit(id, name, price, quantity, organic, colour);
                            cart.AddToCart(fruit, quantity);
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
            }
            if (isAdded == false)
            {
                MessageBox.Show("Oops, you have not selected any fruits to be added!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Fruit(s) is added to Cart. Do you want to go to cart?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Hide();
                new CartWindow(cart, c).Show();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void LoadInventory()
        {
            List<Fruit> frList = fList.ListFruit("fruit.txt");

            fruitTable.Rows.Clear();
            foreach (Fruit f in frList)
            {
                bool check = false;

                int rowIndex = fruitTable.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)fruitTable.Rows[rowIndex].Cells["quantity"];
                LoadQuantity(comboBoxCell, f.Quantity);

            }
        }

        private void LoadInventoryAfterAddingToCart() //displays the inventory without those that are added in the cart
        {
            List<Fruit> frList = fList.ListFruit("fruit.txt");
            List<CartItem> tempCart = cart.GetCartItems();
            fruitTable.Rows.Clear();

            foreach (Fruit f in frList)
            {
                bool isFruitInCart = tempCart.Any(c => c.Fruit.Id == f.Id);
                if (!isFruitInCart)
                {
                    int rowIndex = fruitTable.Rows.Add(false, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                    DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)fruitTable.Rows[rowIndex].Cells["quantity"];
                    LoadQuantity(comboBoxCell, f.Quantity);
                }
            }
        }


        private void LoadQuantity(DataGridViewComboBoxCell comboBoxCell, int quantity)
        {
            comboBoxCell.Items.Clear();
            for (int i = 0; i <= quantity; i++)
            {
                comboBoxCell.Items.Add(i.ToString());
            }
        }

        private void FruitTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {

                if (e.ColumnIndex == fruitTable.Columns["quantityComboBox"].Index)
                {
                    var comboBoxColumn = fruitTable.Columns["quantityComboBox"] as DataGridViewComboBoxColumn;
                    if (comboBoxColumn != null && comboBoxColumn.Items.Count > 0)
                    {
                        e.ThrowException = false;
                        e.Cancel = false;
                        fruitTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = comboBoxColumn.Items[0];
                    }
                }
            }
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            Hide();
            new CartWindow(cart, c).Show();
        }

        private void myAccountButton_Click(object sender, EventArgs e)
        {
            Hide();
            new MyAccount(c).Show();
        }

        private void organicSubMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView
            fruitTable.Rows.Clear();

            // Load the list of fruits from the file
            List<Fruit> frList = fList.ListFruit("fruit.txt");

            // Filter and display only organic fruits
            foreach (Fruit f in frList)
            {
                if (f.Organic)
                {
                    bool check = false;

                    int rowIndex = fruitTable.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                    DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)fruitTable.Rows[rowIndex].Cells["quantity"];
                    LoadQuantity(comboBoxCell, f.Quantity);
                }
            }
        }

        private void nonOrganicSubMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView
            fruitTable.Rows.Clear();

            // Load the list of fruits from the file
            List<Fruit> frList = fList.ListFruit("fruit.txt");

            // Filter and display only organic fruits
            foreach (Fruit f in frList)
            {
                if (!f.Organic)
                {
                    bool check = false;

                    int rowIndex = fruitTable.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                    DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)fruitTable.Rows[rowIndex].Cells["quantity"];
                    LoadQuantity(comboBoxCell, f.Quantity);
                }
            }
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            new FAQ().Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            fruitTable.Rows.Clear();
            List<Fruit> fList = FruitList.SearchFruit(SearchTextBox.Text);
            if (fList != null)
            {
                bool check = false;
                foreach (Fruit f in fList)
                {
                    int rowIndex = fruitTable.Rows.Add(check, f.Id, f.Name, f.Price, f.Quantity, f.Organic, f.Colour);
                    DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)fruitTable.Rows[rowIndex].Cells["quantity"];
                    LoadQuantity(comboBoxCell, f.Quantity);
                }
            }
            else
            {
                MessageBox.Show($"There are no fruits with the name: {SearchTextBox.Text}!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter key is pressed, trigger the login button's click event
            {
                SearchButton_Click(sender, e);
            }
        }
    }
}
