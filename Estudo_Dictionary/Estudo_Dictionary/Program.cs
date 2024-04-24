using System;
using System.Collections.Generic;

namespace Estudo_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "Maria@gmail.com";
            cookies["phone"] = "9977221221";
            cookies["phone"] = "0000000002";

            Console.WriteLine(cookies["phone"]);

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
