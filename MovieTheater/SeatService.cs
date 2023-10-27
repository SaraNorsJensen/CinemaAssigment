using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    internal class SeatService : ISeatService
    {
        public bool ReserveSeat(int SeatNumber)
        {
            Seat SelectedSeat = AllSeats.Find(u=> u.Number == SeatNumber);

            if (SelectedSeat != null && SelectedSeat.Reserved==false)
            {
                SelectedSeat.Reserved = true;
                return true;
            }
            return false;
        }

        List<Seat> ISeatService.AllSeats()
        {
            return AllSeats;
        }

        private List<Seat> AllSeats = new List<Seat>()
        {
           new Seat {Number=1},
           new Seat {Number=2},
           new Seat {Number=3},
           new Seat {Number=4},
           new Seat {Number=5},
           new Seat {Number=6},
           new Seat {Number=7},
           new Seat {Number=8},
           new Seat {Number=9},
           new Seat {Number=10},
           new Seat {Number=11},
           new Seat {Number=12}
        };
    }
}
