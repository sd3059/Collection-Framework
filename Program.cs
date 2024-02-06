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
            /* HashSet is a generic collection, under the namespace System.Collections.Generic, here the datatype is generalized
               and only single type of data can be added. */

            HashSet<string> hs = new HashSet<string>(); // hashset has been defined, with an object named as hs
            hs.Add("Shouvik"); // Data of only a single type is generated
            hs.Add("Section B"); // value declaration and we are using Add() method, for adding the elements
            hs.Add("Class A");
            hs.Add("Promoted");
            hs.Add("Yes");

            Console.WriteLine(hs.Count); // to count the total number of elements
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var val in hs) // using the foreach loop to display the elements
            {
                Console.WriteLine(val);
            }

            //hs.Remove("Class A"); // here we remove the element of our choice using Remove() method, note that in order to remove the element we also need to specify the exact element inside the parameter

            //Console.WriteLine("----------------------------------------------------------------");
            //foreach (var val in hs) // using the foreach loop to display the elements
            //{
            //    Console.WriteLine(val);
            //}

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------");
            HashSet<string> hs1 = new HashSet<string>() // 2nd hashset has been declared
            
                {"Shouvik", "Section B", "Class B" ,"Promoted", "No"}; // Elements are declared in another way like this ijn hashset

            //hs1.Clear(); // removes all the elemnt from the hashset collection

            foreach (var value in hs1) // using the foreach loop to display the elements for the second hashset
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("----------------------------------------------------------------");

            hs.UnionWith(hs1); // suppose if to to hashset are there then we can use this function to union (combine) all the elemnts of the hashsets

            foreach (var ele in hs) // displaying all the elemnts of both the hashsets using a variable ele 
            {
                Console.WriteLine(ele);
            } 

            
            HashSet<string> hs2 = new HashSet<string>();
            hs2.Add("Prakhar");
            hs2.Add("Added");
            hs2.Add("Group Four");
            hs2.Add("Promoted");
            
            
            
            
            HashSet<string> hs3 = new HashSet<string>();



            hs2.Add("Prakhar");
            hs2.Add("Added");
            hs2.Add("No Group");
            hs2.Add("Not Promoted");
            
            hs2.IntersectWith(hs3); //Intersection Method

            foreach (var var in hs2)
            {
                Console.WriteLine(var);
            }

            hs2.ExceptWith(hs3); //ExceptWith Method

            foreach (var var2 in hs2)
            {
                Console.WriteLine(var2);
            }
            Console.ReadLine();
        }
    }
        
} 