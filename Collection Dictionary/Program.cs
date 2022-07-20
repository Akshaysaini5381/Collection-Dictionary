using System;
using System.Collections.Generic;
namespace Collection_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "akshay");
            d.Add(2, "s");
            d.Add(3, "akshay");
            d.Add(4, "z");
            

            foreach (KeyValuePair<int,string> item in d)
            {
                Console.WriteLine(" "+item.Key+" "+item.Value);
            }

          /*  foreach (KeyValuePair<int, string> item in d)
            {
                Console.WriteLine(" " + item);
            }*/
            Console.WriteLine("Total "+d.Count);
            
        }
    }
}
