using System;
using Excecoes_Ex001.Entities;

namespace Excecoes_Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkin >= checkout)
            {
                Console.WriteLine("Error invalid data");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkin, checkout);

                Console.WriteLine(reservation);

                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Error, invalid data");
                }
                else if (checkin >= checkout)
                {
                    Console.WriteLine("Error, invalid data");
                }
                else
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
