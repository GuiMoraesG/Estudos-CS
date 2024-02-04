using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Gui");
            list.Add("Alex");
            list.Add("Mariooo");
            list.Add("Ana");
            list.Insert(2, "DDDDDD");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Numero de elementos " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int s3 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(s3);

            int s4 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(s4);

            List<string> listaFiltrada = list.FindAll(x => x.Length > 5);

            foreach (string item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''");

            list.Remove("Alex");
            //list.RemoveAll(x => x[0] == 'D');
            list.RemoveAt(2);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
