using System;
using System.Collections.Generic; // Collection framework for Generic Collection
using System.Linq;
using System.Collections; // Collection framework for Non-Generic Collection 
using System.Text;
using System.Threading.Tasks;

namespace Collection_Framework
{
    internal class Program
    {
        static public void Main()
        {
            /* Now, we will talk about List Collection, which comes under the Generic Collection namespace, means
               the list collection of items is generic and for a particular list collection object the elements will
               be of the same datatype, means they are strongly typed and unlike non-generic collection
               an object of list collection cannot have different datatypes, but here different objects can be created 
               of different datatypes. */

            List<int> mynumbers = new List<int>();
            mynumbers.Add(77);
            mynumbers.Add(22);
            mynumbers.Add(88);
            mynumbers.Add(11);
            mynumbers.Add(44);
            mynumbers.Add(33);

            foreach (int item in mynumbers)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("---------------------------------------------------------");

            // mynumbers.AddRange(mynumbers); // it basically doubles the range of the object elements

            // mynumbers.Insert(1, 55); // Inserts the new element at the index position specified, thus increaing the index position of the other elements by +1

            // mynumbers.InsertRange(3, mynumbers); // Inserts the entire collection of elements of mynumber at the index 3

            // mynumbers.Remove(11); // Removes the element being specified

            // mynumbers.RemoveAt(4); // Removes the element of the particular index being defined

            // mynumbers.RemoveRange(1, 4); // First define the index position and then count of elements to be removed

            // RemoveAll()

            foreach (int item in mynumbers)
            {
                Console.WriteLine(item);

            }


            Console.WriteLine("---------------------------------------------------------");



            //Console.WriteLine(mynumbers.Count); // Counts the total number of elements in the object mynumbers

            // Console.WriteLine("----------------------------------------------------------");

            // mynumbers.Sort(); // Sort property to sort the elements of the object mynumbers

            // Console.WriteLine(mynumbers.Capacity); //It is used to check the storage capacity, of how many elements we can store, also with the help of auto-resizing functionality it can double it's capacity

            // Console.WriteLine(mynumbers[1]); // Assigning the index position, to access the value of the particular index position

            //Console.WriteLine("----------------------------------------------------------");
            //foreach (int item in mynumbers)
            //   {
            //    Console.WriteLine(item);

            //   }

            // Console.WriteLine("----------------------------------------------------------");

            List<string> names = new List<string>();
            names.Add("Shouvik");
            names.Add("Raj");
            names.Add("Saurabh");
            names.Add(null); // we can also store null values for reference type object elements
            names.Add("Saurabh"); // duplicate values also

            foreach (string item1 in names)
            {
                Console.WriteLine(item1);
            }




            Console.ReadLine(); 
        }
    }
        
} 