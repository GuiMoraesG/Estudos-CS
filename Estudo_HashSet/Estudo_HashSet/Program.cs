using System;
using System.Collections.Generic;

namespace Estudo_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("PC");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Maria"));

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
