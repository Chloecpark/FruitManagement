using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class FruitList
    {
        private static List<Fruit> fruitList;

        public FruitList()
        {
            fruitList = new List<Fruit>();
        }

        public void LoadFruit(string filename) //load the fruit objects in the filename provided
        {
            StreamReader fileContent = new StreamReader(filename);
            Fruit fruitTemp;
            fruitList.Clear(); //clears the list so that the objects can be loaded properly

            while (!fileContent.EndOfStream)
            {
                fruitTemp = new Fruit();
                string line = fileContent.ReadLine();
                fruitTemp.LoadFruit(line); //load the fruit detail from file to respective fields
                fruitList.Add(fruitTemp);
            }
            fileContent.Close();
        }

        public static Fruit SearchFruit(int id) //searches the fruit with the corresponding id
        {
            foreach (Fruit f in fruitList)
            {
                if (f.Id == id)
                {
                    return f;
                }
            }
            return null;
        }

        public static List<Fruit> SearchFruit(string name)
        {
            List<Fruit> matchingFruits = new List<Fruit>(); // Create a list to store matching fruits

            foreach (Fruit f in fruitList)
            {
                if (f.Name.ToLower() == name.ToLower())
                {
                    matchingFruits.Add(f); // Add the matching fruit to the list
                }
            }
            if (matchingFruits.Count > 0)
            {
                return matchingFruits;
            }
            return null; // Return null if no matching fruits were found
        }

        public List<Fruit> ListFruit(string filename)
        {
            StreamReader content = new StreamReader(filename);
            Fruit fruit;
            fruitList.Clear();


            while (!content.EndOfStream)
            {
                fruit = new Fruit();
                string line = content.ReadLine();
                fruit.ListFruit(line);
                fruitList.Add(fruit);
            }
            content.Close();
            return fruitList;

        }
    }
}
