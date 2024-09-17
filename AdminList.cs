using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class AdminList
    {
        private static List<Admin> adminList;

        public AdminList()
        {
            adminList = new List<Admin>();
        }

        public void LoadAdmin(string filename) //load the admin objects in the filename provided
        {
            StreamReader fileContent = new StreamReader(filename);
            Admin adminTemp;
            adminList.Clear(); //clears the list so that the objects can be loaded properly

            while (!fileContent.EndOfStream)
            {
                adminTemp = new Admin();
                string line = fileContent.ReadLine();
                adminTemp.LoadAdmin(line); //load the admin detail from file to respective fields
                adminList.Add(adminTemp);
            }
            fileContent.Close();
        }

        public static Admin SearchAdmin(int id) //searches the admin with the corresponding id
        {
            foreach (Admin a in adminList)
            {
                if (a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
