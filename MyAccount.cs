using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment2
{
    public partial class MyAccount : Form
    {
        private Customer c;
        private DateTime newDob;

        public MyAccount(Customer customer)
        {
            InitializeComponent();
            this.c = customer;
        }

        // print customer's current detail (before update)
        private void MyAccount_Load(object sender, EventArgs e)
        {
            printIdLabel.Text = c.Id.ToString();
            fNameTextBox.Text = c.FName;
            lNameTextBox.Text = c.LName;
            printBalanceLabel.Text = c.Balance.ToString();
            if (DateTime.TryParseExact(c.Dob, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dob))
            {
                dateTimePicker.Value = dob;
            }
            changePWTextBox.Text = GetPassword(c.Id);

        }

        // print customer's current password (before update)
        private string GetPassword(int id)
        {
            string pw = "";
            string[] lines = File.ReadAllLines("login.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[0] == c.Id.ToString())
                {
                    return pw = parts[1];
                }
            }
            return pw;
        }


        // save updated value in the text file
        private void changePWbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = c.Id;
                string pw = changePWTextBox.Text;
                List<string> lines = new List<string>(File.ReadAllLines("login.txt"));
                // Find and modify the specific line
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (fields.Length == 2)
                    {
                        int cid = Convert.ToInt32(fields[0]);
                        if (cid == id)
                        {
                            // Check if the data has actually changed
                            if (fields[1] != pw)
                            {
                                // Update the values in the fields array
                                fields[1] = pw;

                                // Join the fields back into a single string and replace the line
                                lines[i] = string.Join(',', fields);

                                // Data has changed, display the success message
                                try
                                {
                                    // Write the modified content back to the file
                                    File.WriteAllLines("login.txt", lines);
                                    MessageBox.Show("File updated successfully.", "Success");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred: " + ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("New password cannot be the same as previous password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // save updated value in the text file
        private void saveChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = c.Id;
                string fName = fNameTextBox.Text;
                string lName = lNameTextBox.Text;
                string dob = newDob.ToString("dd/MM/yyyy");

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
                            // Check if the data has actually changed
                            if (fields[1] != fName || fields[2] != lName || fields[3] != dob)
                            {
                                // Update the values in the fields array
                                fields[1] = fName;
                                fields[2] = lName;
                                fields[3] = dob;

                                // Join the fields back into a single string and replace the line
                                lines[i] = string.Join(',', fields);

                                // Data has changed, display the success message
                                try
                                {
                                    // Write the modified content back to the file
                                    File.WriteAllLines("customer.txt", lines);
                                    MessageBox.Show("File updated successfully.", "Success");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred: " + ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No details changed!\n", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please enter valid input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            newDob = dateTimePicker.Value;
            c.Dob = newDob.ToString("dd/MM/yyyy");
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Customer.ResetNextToBeAssignedId();
            new CustomerMenu(c.Id).Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            new LogIn().Show();
            Customer.ResetNextToBeAssignedId();
        }
    }
}
