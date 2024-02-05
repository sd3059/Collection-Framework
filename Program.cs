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
            

            /* Stack (Non-Generic) & (Generic), so firstly in a stack we store pile of objects,
               suppose like one object on the top of other object and the process continues,
               and now we will discuss about NON-GENERIC STACK where we will store elements of different datatype */
            Stack mystack = new Stack();
            mystack.Push("Anil"); // String value
            mystack.Push(25); // Integer value
            mystack.Push('B'); // Character value 
            mystack.Push(true); // Boolean value
            //mystack.Push(null); // Null value
            mystack.Push("Anil"); // Duplicate value
            mystack.Push(6.11); // Double value
            Console.WriteLine("------------------------");
            Console.WriteLine( mystack.Count); // Counts the total number of elements and returns an integer value
            Console.WriteLine("------------------------");
            Console.WriteLine(mystack.Peek()); // Displays the peek or the top element of the stack
            Console.WriteLine("------------------------");
            Console.WriteLine(mystack.Contains("Anil")); // Checks if the element is present in the stack collection and return a bool value
            Console.WriteLine("------------------------");

            foreach (object item2 in mystack) // Using foreach loop to proint the values
            {
                Console.WriteLine(item2);
            }

            mystack.Pop(); // To remove the first element from the stack, the element which was stored last, this method is used

            mystack.Clear(); // Removes all the elemnts in the stack
            Console.WriteLine("------------------------");
            foreach (object item2 in mystack) // Using foreach loop to print the values
            {
                Console.WriteLine(item2);
            }

            /* Now we will discuss about Generic Stack Collection */

            Stack<int> mystack2 = new Stack<int>();
            mystack2.Push(9); // Only the value of a single datatype is stored as in generic collection we generalize the values
            mystack2.Push(10);

            foreach (var items2 in mystack2)
            {
                Console.WriteLine(items2);
            }

            /* And all the methods and properties used are same like non-generic collection */
            Console.ReadLine();



        }
    }
}
