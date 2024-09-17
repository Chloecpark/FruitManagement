using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2
{
    public class CustomerList
    {
        private static List<Customer> customerList;

        public CustomerList()
        {
            customerList = new List<Customer>();
        }

        public void LoadCustomer(string filename) //load the customer objects in the filename provided
        {
            StreamReader fileContent = new StreamReader(filename);
            Customer customerTemp;
            customerList.Clear(); //clears the list so that the objects can be loaded properly

            while (!fileContent.EndOfStream)
            {
                customerTemp = new Customer();
                string line = fileContent.ReadLine();
                customerTemp.LoadCustomer(line); //load the customer detail from file to respective fields
                customerList.Add(customerTemp);
            }
            fileContent.Close();
        }

        public static Customer SearchCustomer(int id) //searches the customer with the corresponding id
        {
            foreach (Customer c in customerList)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        // Search Customer by name
        public static List<Customer> SearchCustomer(string fName)
        {
            List<Customer> matchingCustomers = new List<Customer>();

            foreach (Customer c in customerList)
            {
                if (c.FName.ToLower() == fName.ToLower())
                {
                    matchingCustomers.Add(c);
                }
            }
            if (matchingCustomers.Count > 0)
            {
                return matchingCustomers;
            }
            return null;
        }

        public List<Customer> ListCustomer(string filename)
        {
            StreamReader content = new StreamReader(filename);
            Customer customer;
            customerList.Clear();

            while(!content.EndOfStream)
            {
                customer = new Customer();
                string line = content.ReadLine();
                customer.ListCustomer(line);
                customerList.Add(customer);
            }
            content.Close();
            return customerList;
        }

    }
}
