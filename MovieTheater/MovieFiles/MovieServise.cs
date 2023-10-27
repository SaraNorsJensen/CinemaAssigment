using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.MovieFiles
{
    internal class MovieServise : IMovieService
    {
        public List<Movie> SeeMovies()
        {
            return AllMovies;
        }

        public Movie SelectedMovie(int SelectedMovieNumber)
        {
            return AllMovies.Find(u => u.Number == SelectedMovieNumber);
        }

        private List<Movie> AllMovies = new List<Movie>()
        {
           new Movie {Name="Sherk 10", PlayTime = new TimeSpan(1,49,0), Number=1, AiringTime= new DateTime(2029, 3, 29, 1,1,1)},
           new Movie {Name="Peace on earth", PlayTime = new TimeSpan(6,6,6), Number=2, AiringTime= new DateTime(2029, 4, 1, 16, 30,0)},
           new Movie {Name="the blueray logo that hits the corner", PlayTime = new TimeSpan(12,12,12), Number=3, AiringTime= new DateTime(2015, 11, 29, 23, 59, 59)}
        };
    }
}
