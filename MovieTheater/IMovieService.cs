﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    internal interface IMovieService
    {
        List<Movie> SeeMovies();
        Movie SelectedMovie(int SelectedMovieNumber);
    }
}
