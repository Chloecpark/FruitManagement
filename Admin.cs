using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Admin
    {
        private static int nextToBeAssignedId = 20000; //sets the nextToBeAssignedId for loading the objects
        private int id;
        private string fName;
        private string lName;
        private string dob;

        public Admin()
        {
            this.id = nextToBeAssignedId;
            nextToBeAssignedId++;
            this.fName = "";
            this.lName = "";
            this.dob = "";
        }

        public static void ResetNextToBeAssignedId() //resets the nextToBeAssignedId so that the objects can be loaded properly
        {
            nextToBeAssignedId = 20000;
        }

        public void LoadAdmin(string fileName) //loading the admin entry in the text file provided
        {
            try
            {
                string[] lines = fileName.Split('\n'); //split the content into individual lines

                foreach (string line in lines)
                {
                    string[] fields = line.Split(','); //split each line into fields separated by comma
                    if (fields.Length == 4) //ensure that there are 4 fields for inputting data
                    {
                        int aId = Convert.ToInt32(fields[0]);
                        if (aId == id) //check if the ID matches the admin's ID
                        {
                            id = aId;
                            fName = fields[1];
                            lName = fields[2];
                            dob = fields[3];
                            break; //exits the loop when the admin object is found
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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        } 
    }
}
