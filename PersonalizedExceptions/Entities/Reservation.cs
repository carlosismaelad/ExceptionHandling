using PersonalizedExceptions.Entities.Exceptions;

namespace PersonalizedExceptions.Entities;

public class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation()
    {
        
    }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check-Out date must be after Check-In date.");
        }
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {
        TimeSpan duration = CheckOut.Subtract(CheckIn);
        return (int)duration.TotalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut)
    {
        DateTime now = DateTime.Now;
        if (checkIn < now || checkOut < now)
        {
            throw new DomainException("Reservation dates to update must be future dates.");
        }
        if (checkOut <= checkIn)
        {
            throw new DomainException("Check-Out date must be after Check-In date.");
        }
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public override string ToString()
    {
        return "Room "
               + RoomNumber
               + ", check-in: "
               + CheckIn.ToString("dd/MM/yyyy")
               + ", check-out: "
               + CheckOut.ToString("dd/MM/yyyy")
               + ", "
               + Duration()
               + " night(s).";
    }
    
    
}