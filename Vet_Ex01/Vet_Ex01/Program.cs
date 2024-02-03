using System;

namespace Vet_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms ?: ");
            int n = int.Parse(Console.ReadLine());

            Hotel[] data = new Hotel[9];

            for (int i = 0; i < n; i++)
            {
                int j = i;
                Console.WriteLine($"Rent #{j += 1}: ");

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                if (data[room] == null)
                {
                    data[room] = new Hotel(nome, email, room);
                }
                else
                {
                    Console.WriteLine("Quarto já ocupado");
                }
            }

            Console.WriteLine("Busy Rooms: ");

            for (int i = 0; i < 9; i++)
            {
                if (data[i] != null)
                {
                    Console.WriteLine($"{data[i].Room}: {data[i].Nome}, {data[i].Email}");
                }
            }
        }
    }
}
