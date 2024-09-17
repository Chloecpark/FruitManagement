using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace Assignment2
{
    public class Customer
    {
        private static int nextToBeAssignedId = 10000; //sets the nextToBeAssignedId for loading the objects
        private int id;
        private string fName;
        private string lName;
        private string dob;
        private double balance;

        public Customer() 
        { 
            this.id = nextToBeAssignedId;
            nextToBeAssignedId++;
            this.fName = "";
            this.lName = "";
            this.dob = "";
            this.balance = 0.0;
        }

        public Customer(string fName, string lName, string dob, double balance)
        {
            this.fName = fName;
            this.lName = lName;
            this.dob = dob;
            this.balance = balance;
        }

        public static void ResetNextToBeAssignedId() //resets the nextToBeAssignedId so that the objects can be loaded properly
        {
            nextToBeAssignedId = 10000;
        }

        public void LoadCustomer(string fileName) //loading the customer entry in the text file provided
        {
            try
            {
                string[] lines = fileName.Split('\n'); //split the content into individual lines

                foreach (string line in lines)
                {
                    string[] fields = line.Split(','); //split each line into fields separated by comma
                    if (fields.Length == 5) //ensure that there are 5 fields for inputting data
                    {
                        int cId = Convert.ToInt32(fields[0]);
                        if (cId == id) //check if the ID matches the customer's ID
                        {
                            id = cId;
                            fName = fields[1];
                            lName = fields[2];
                            dob = fields[3];
                            balance = Convert.ToDouble(fields[4]);
                            break; //exits the loop when the customer object is found
                        }
                    }
                    else
                    {
                        MessageBox.Show("Index out of bounds encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Data format exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void ListCustomer(string fileLine)
        {
            try
            {
                string[] fields = fileLine.Split(',');
                if (fields.Length == 5)
                {
                    id = Convert.ToInt32(fields[0]);
                    fName = fields[1];
                    lName = fields[2];
                    dob = fields[3];
                    balance = Convert.ToDouble(fields[4]);
                }
                else
                {
                    MessageBox.Show("Index out of bounds encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Data format exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found exception encountered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static int NextToBeAssignedId
        {
            get { return nextToBeAssignedId; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FName
        { 
            get { return fName; } 
            set {  fName = value; } 
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
