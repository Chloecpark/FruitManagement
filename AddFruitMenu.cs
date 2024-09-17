using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment2
{
    public partial class AddFruitMenu : Form
    {
        int nextId;
        int id;

        public AddFruitMenu(int id)
        {
            InitializeComponent();
            nextId = Fruit.NextToBeAssignedId;
            this.id = id;
        }

        private void AddFruitMenu_Load(object sender, EventArgs e)
        {
            int rowIndex = inventoryGrid.Rows.Add(nextId, null, null, null, null, null);
            inventoryGrid.Rows[rowIndex].Cells["fAddButton"].Value = "Add";

        }
        private void inventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == inventoryGrid.Columns["fAddButton"].Index)
                {
                    string name = inventoryGrid.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    double price = Convert.ToDouble(inventoryGrid.Rows[e.RowIndex].Cells["price"].Value);
                    int quantity = Convert.ToInt32(inventoryGrid.Rows[e.RowIndex].Cells["stock"].Value);
                    bool organic = Convert.ToBoolean(inventoryGrid.Rows[e.RowIndex].Cells["organic"].Value);
                    string colour = inventoryGrid.Rows[e.RowIndex].Cells["colour"].Value.ToString();

                    Fruit newFruit = new Fruit(name, price, quantity, organic, colour);
                    newFruit.Id = nextId;
                    try
                    {
                        using (StreamWriter writer = new StreamWriter("fruit.txt", true)) //append the fruit's details to the "fruit.txt" file
                        {
                            string fruitDetails = $"{newFruit.Id},{newFruit.Name},{newFruit.Price},{newFruit.Quantity},{newFruit.Organic},{newFruit.Colour}";
                            writer.WriteLine(fruitDetails);
                            writer.Close();
                        }
                        Fruit.ResetNextToBeAssignedId();
                        Admin.ResetNextToBeAssignedId();
                        if (MessageBox.Show("New fruit added successfully. Click OK to return to admin menu.", "Success") == DialogResult.OK)
                        {
                            Hide();
                            new AdminMenu(id).Show();
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
            new AdminMenu(AdminList.SearchAdmin(id).Id).Show();
        }
    }
}
