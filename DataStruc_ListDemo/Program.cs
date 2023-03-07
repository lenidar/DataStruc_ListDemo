using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStruc_ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            // 0 , 0 , 0 , 0 , 0
            List<int> y = new List<int>();
            // 

            x[0] = 6;
            x[1] = 7;
            x[2] = 8;

            //y.Add(8); // appends things at the end of the list
            //y.RemoveAt(2); // remove an index from a list
            //y.Clear(); // clear the contents of the list
            //y.Count(); // count how many items are in the list
            //y.Insert(5, 6); // this inserts an item into the list at a given index, in this case it is inserting the value 6 in index 5
            //y[5] = 7;

            #region Demo
            List<string> groceryList = new List<string>();
            string groceryItem = "";
            bool cont = true;

            while (cont)
            {
                Console.WriteLine("\n\nYou have " + groceryList.Count + " things in your list");
                Console.WriteLine("Input y to add things to the list and n to just display the list");
                groceryItem = Console.ReadLine().ToLower();
                switch (groceryItem)
                {
                    case "y":
                        Console.WriteLine("What do you want to add to the list?");
                        groceryItem = Console.ReadLine();
                        groceryList.Add(groceryItem);
                        //groceryList.Insert(0, groceryItem);
                        break;
                    case "n":
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Please follow the instructions!");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the grocery list thingy");
            Console.WriteLine("You have " + groceryList.Count + " things in the list");
            foreach (string grocery in groceryList)
                Console.WriteLine(grocery);
            Console.WriteLine("\n\n");
            for(int a = 0; a < groceryList.Count(); a++)
                Console.WriteLine(groceryList[a]);
            Console.WriteLine("\n\n");
            int b = 0;
            while(b < groceryList.Count())
            {
                Console.WriteLine(groceryList[b]);
                b++;
            }
            #endregion

            Console.ReadKey();
        }
    }
}
