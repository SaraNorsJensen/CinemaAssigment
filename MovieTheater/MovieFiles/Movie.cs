using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.MovieFiles
{
    internal class Movie
    {
        public string Name { get; set; }
        public TimeSpan PlayTime;
        public int Number { get; set; }
        public DateTime AiringTime { get; set; }
    }
}
