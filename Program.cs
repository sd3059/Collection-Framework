using System;
using System.Collections.Generic; // Collection framework for Generic Collection
using System.Linq;
using System.Collections; // Collection framework for Non-Generic Collection 
using System.Text;
using System.Threading.Tasks;

namespace Collection_Framework
{
    public class Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }

} 