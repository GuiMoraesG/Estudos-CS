using System;

namespace Excecoes_Ex001.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, Check-in: {Checkin.ToString("dd/MM/yyyy")}, Check-out: {Checkout.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

        public string UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                return "Error, invalid data";
            }

            if (checkin >= checkout)
            {
                return "Error, invalid data";
            }

            Checkin = checkin;
            Checkout = checkout;

            return null;
        }
    }
}
