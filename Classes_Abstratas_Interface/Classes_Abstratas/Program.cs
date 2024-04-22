using Classes_Abstratas.Entites;
using System;
using System.Collections.Generic;

namespace Classes_Abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle(Color.Red, 2);
            IShape s2 = new Rectangle(Color.Black, 3.5, 4.2);

            Console.WriteLine(s1.Area());
            Console.WriteLine(s2.Area());
        }
    }
}
