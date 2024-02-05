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
        static void Main(string[] args)
        {
            /* HashTable Collection class 
               Here we will discuss about Hashtable and how the elements are stored in the hashtable
               like we use hashtable, firstly we are using the Non-Generic Collection Framework to create the hashtable 
               collection class, and the hashtable is different from the arraylist in the manner that in the hashtable 
               we can define the key as per our requirement and then assign a value to it, but in arraylist a pre-defined
               key is present for every element, i.e. pre-defined index position and that becomes difficult to determine 
               the element, i.e. exactly what element we want to access and so we use hashtable
               And it is also to be noted that the elements with the key and values will displayed randomly */


            /* Hashtable ht = new Hashtable()
            {
                {"Name", "Shouvik"},
                {"Class", "A" },
                {"Passed", true}
            }; */

            Hashtable ht = new Hashtable();
            ht.Add("Name", "Shouvik"); // To add the elements in the hashtable
            ht.Add("Designation", "Manager"); // Elements of the different datatypes can be stored
            ht.Add("Location", "Hydrebad");
            ht.Add("Salary", 25000);
            ht.Add("Promoted", "AVP");

            Console.WriteLine(ht.Count);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Name".GetHashCode()); // Gives us the hash code that is present at the back-end of integer value
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(ht.Contains("Designation")); // Checks if the key is present or not
            Console.WriteLine(ht.ContainsKey("Location")); // Checks if the key is present or not
            Console.WriteLine(ht.ContainsValue(25000)); // Checks if the value is present or not
            Console.WriteLine("-----------------------------------------------------------");

            //Console.WriteLine(ht["Designation"]); // To access the element in the hashtable

            foreach (object key  in ht.Keys)
            {
                Console.WriteLine(key); //It will print all the keys present in the hashtable collection
            }

            Console.WriteLine("-----------------------------------------------------------");

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(ht[key]); // It will display all the values of the keys in the collection
            }

            Console.WriteLine("-----------------------------------------------------------");

            foreach (object value in ht.Values)
            {
                Console.WriteLine(value); // It will display all the values of the keys in the collection
            }

            Console.WriteLine("-----------------------------------------------------------");

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]); //It will print all the key as well as the value of the keys
            }

            ht.Remove("Salary"); // Helps to remove the particular key from the collection

            // ht.Clear(); // Removes all the key values from the collection
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------");
            
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]); 
            }
        }
    }
}
