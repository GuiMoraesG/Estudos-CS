using Hashcode_Equals.Entities;
using System;

namespace Hashcode_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client() { Name = "Pedro", Email = "pedro@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
