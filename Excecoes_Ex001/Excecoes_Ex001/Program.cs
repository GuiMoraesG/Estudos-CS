using System;
using Excecoes_Ex001.Entities;
using Excecoes_Ex001.Entities.Exceptions;

namespace Excecoes_Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reservation);


                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (FormatException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
