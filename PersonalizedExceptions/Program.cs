using PersonalizedExceptions.Entities;

namespace PersonalizedExceptions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());
            

            if (checkIn > checkOut)
            {
                Console.WriteLine("Error: Check-Out date must be after Check0-In date.");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-In date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());


                string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
                
            }


        }
    }
}