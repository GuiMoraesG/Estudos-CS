using Heranca.Entities;
using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            Account account1 = businessAccount;

            Console.WriteLine(account1);
        }
    }
}
