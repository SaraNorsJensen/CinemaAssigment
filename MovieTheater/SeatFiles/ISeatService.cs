using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.SeatFiles
{
    internal interface ISeatService
    {
        List<Seat> AllSeats(); 
        bool ReserveSeat(int SeatNumber);
    }
}
