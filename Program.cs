using System;
using System.Collections.Generic; // Collection framework for Generic Collection
using System.Linq;
using System.Collections; // Collection framework for Non-Generic Collection 
using System.Text;
using System.Threading.Tasks;

namespace Collection_Framework
{
    public class LinkedList
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }

} 