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
            /* Queue : A queue in layman term is basically a formation of line or a sequence of people of cars.
               In programming a queue is a collection of the list of items that are stored, and it is stored with
               the help of Enqueue method and retrieved or removed with the help of Dequeue method.
               There are several properties and methods of Queue like Count [Property], Enqueue [Method], Dequeue [Method],
               Clear [Method], Peek [Method], Contains [Method] and so on.
               Some of the features of Queue is that:
               1) It stores the elements in the list in FIFO order. (First In First Out)
               2) It contains the elements in the order they were added.
               3) Queue collection allows multiple duplicate and null values. */
            
            
            /* First we will discuss about Non-Generic Queue Collection where we can store elements of different 
               datatype under the parent datatype object, which is already pre-defined in the Collection Framework,
               (System.Collections). Here the object datatype is pre-defined, under which certain datatypes are already
               predefined, but it has to be noted that we can only use those datatypes, in this collection.
               And also like the object datatype is pre-defined and so the user can't define any datatype inside the 
               queue, as we can only use the pre-defined datatypes under the object datatype. */

            Queue myqueue = new Queue(); // An object named as myqueue has been created in the Queue collection
            myqueue.Enqueue("Aman"); // Now we are storing the elements in the queue collection using enqueue method
            myqueue.Enqueue('A'); // Char datatype
            //myqueue.Enqueue(null); // An empty space is added using the null property
            myqueue.Enqueue("Aman"); // Duplicate value in generated
            myqueue.Enqueue(25); // Integer datatype
            myqueue.Enqueue(true); // Bool value
            myqueue.Enqueue(5.9); // Float value

            

            foreach (object item in myqueue) // A foreach loop is defined to display all the elements with the object datatype
            {
                Console.WriteLine( item);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Total no. of elements: " + myqueue.Count); // This property is used to count the total number of elements in the queue
            Console.WriteLine("-------------------");
            Console.WriteLine("Display the first element: " + myqueue.Peek()); // This method is used to display the first element

            Console.WriteLine("-------------------");
            Console.WriteLine("Check if the element is present or not: " + myqueue.Contains("Aman")); // Checks if the element is present or not and returns a bool value




            //myqueue.Clear(); // This method removes all the elemnts from the queue 

            myqueue.Dequeue(); // This method removes the element which was stored first the the next elemnt and the process continues
            Console.WriteLine("-------------------");
            
            foreach (object item in myqueue) // A foreach loop is defined to display all the elements with the object datatype
            {
                Console.WriteLine(item);
            }

            myqueue.Dequeue();
            Console.WriteLine("-------------------");

            foreach (object item in myqueue) // A foreach loop is defined to display all the elements with the object datatype
            {
                Console.WriteLine(item);
            }

            /* Now we will discuss about Generic Queue Collection where the datatye is defined by the user as 
               per the application requirement in the main function, means it basically generalizes the datatype
               and only the value of that datatype can be used. */

            Queue<int> myqueue2 = new Queue<int>(); // A dataype being defined by the user in the main function and is generalized.
            myqueue2.Enqueue(01); // Now we are storing the elements in the queue collection using enqueue method of only integer type
            myqueue2.Enqueue(02); // 
            //myqueue2.Enqueue(null); // An empty space is added using the null property
            myqueue2.Enqueue(03); 
            myqueue2.Enqueue(04); 
            myqueue2.Enqueue(05); 
            myqueue2.Enqueue(06);

            Console.WriteLine("--------------------------------------------------------------------------------------");
            foreach (object items in myqueue2) // A foreach loop is defined to display all the elements with the object datatype
            {
                Console.WriteLine(items);
            }

            /* And in the same manner all the methods can be also used for Generic queue collection. */



            Console.ReadLine();



        }
    }
}
