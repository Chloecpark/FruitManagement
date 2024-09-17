using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Assignment2
{
    public partial class LogIn : Form
    {
        private Dictionary<int, string> userCredentials; //store user credentials in a dictionary
        public LogIn()
        {
            InitializeComponent();
            userCredentials = new Dictionary<int, string>();
            LoadUserCredentials("login.txt");
            this.FormClosing += new FormClosingEventHandler(LogIn_FormClosing);
        }

        public void LoadUserCredentials(string fileName) //read the user credentials from the text file
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    int id = Convert.ToInt32(parts[0]);
                    string password = parts[1];
                    userCredentials[id] = password;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (FormatException)
            {
                MessageBox.Show("Format exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LogInButton_Click(object sender, EventArgs e) //checks if the id and password matches
        {
            try
            {
                bool loginSuccessful = false;
                //checks if the id and password matches
                if (userCredentials.ContainsKey(Convert.ToInt32(IdTextBox.Text)) && userCredentials[Convert.ToInt32(IdTextBox.Text)] == passwordTextBox.Text)
                {
                    loginSuccessful = true;
                    Hide(); //hides the form
                    //customer only has the id ranging from 10000 to 19999
                    if (Convert.ToInt32(IdTextBox.Text) >= 10000 && Convert.ToInt32(IdTextBox.Text) < 20000)
                    {
                        new CustomerMenu(Convert.ToInt32(IdTextBox.Text)).Show();
                    }
                    //log into admin menu
                    else
                    {
                        new AdminMenu(Convert.ToInt32(IdTextBox.Text)).Show();
                    }
                }
                if (!loginSuccessful)
                    MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                passwordTextBox.Text = string.Empty;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (FormatException)
            {
                MessageBox.Show("Format exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter key is pressed, trigger the login button's click event
            {
                LogInButton_Click(sender, e);
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
