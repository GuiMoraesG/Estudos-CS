using Enum_Ex02.Entities;
using System;
using System.Collections.Generic;

namespace Enum_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new Comments("Have a nice trip");
            Comments c2 = new Comments("WOW that s awesome");

            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to Brazil", "Im going to Brasil", 15);

            p1.AddComments(c1);
            p1.AddComments(c2);

            Comments c3 = new Comments("Have a nice trip1111");
            Comments c4 = new Comments("WOW that s awesome2222");

            Post p2 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to Brazil333", "Im going to Brasil333", 100);

            p2.AddComments(c3);
            p2.AddComments(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
