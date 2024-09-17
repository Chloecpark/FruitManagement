using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2
{
    public class Fruit
    {
        private static int nextToBeAssignedId = 1;
        private int id;
        private string name;
        private double price;
        private int quantity;
        private bool organic;
        private string colour;

        public Fruit()
        {
            this.id = nextToBeAssignedId;
            nextToBeAssignedId++;
            this.name = "";
            this.price = 0.0;
            this.quantity = 0;
            this.organic = false;
            this.colour = "";
        }

        public Fruit(string name, double price, int quantity, bool organic, string colour)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.organic = organic;
            this.colour = colour;
        }

        public Fruit(int id, string name, double price, int quantity, bool organic, string colour)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.organic = organic;
            this.colour = colour;
        }

        public static void ResetNextToBeAssignedId() //resets the nextToBeAssignedId so that the objects can be loaded properly
        {
            nextToBeAssignedId = 1;
        }

        public void LoadFruit(string fileName) //loading the fruit entry in the text file provided
        {
            try
            {
                string[] lines = fileName.Split('\n'); //split the content into individual lines

                foreach (string line in lines)
                {
                    string[] fields = line.Split(','); //split each line into fields separated by comma
                    if (fields.Length == 6) //ensure that there are 6 fields for inputting data
                    {
                        
                        int fId = Convert.ToInt32(fields[0]);
                        if (fId == id) //check if the ID matches the fruit's ID
                        {
                            id = fId;
                            name = fields[1];
                            price = Convert.ToDouble(fields[2]);
                            quantity = Convert.ToInt32(fields[3]);
                            organic = Convert.ToBoolean(fields[4]);
                            colour = fields[5];
                            break; //exits the loop when the fruit object is found
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

        public void ListFruit (string fileLine)
        {
            try
            {
                string[] fields = fileLine.Split(',');
                if (fields.Length == 6)
                {
                    id = Convert.ToInt32(fields[0]);
                    name = fields[1];
                    price = Convert.ToDouble(fields[2]);
                    quantity = Convert.ToInt32(fields[3]);
                    organic = Convert.ToBoolean(fields[4]);
                    colour = fields[5];
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public bool Organic
        {
            get { return organic; }
            set { organic = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
