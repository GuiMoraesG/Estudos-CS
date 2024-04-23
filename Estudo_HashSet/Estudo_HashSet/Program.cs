using System;
using System.Collections.Generic;

namespace Estudo_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 3, 4, 5, 6, 7, 8, 20 };
            SortedSet<int> b = new SortedSet<int>() { 0, 2, 32, 41, 54, 65, 7, 82, 20 };

            //UNIÃO
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            //INTERSECTION
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d);

            //DIFERENÇA
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collections)
        {
            foreach (T obj in collections)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
