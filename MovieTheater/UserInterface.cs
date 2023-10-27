using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    public class UserInterface
    { 
        private LogInService login = new LogInService();
        private IMovieService MovieServise = new MovieServise();
        private ISeatService SeatService = new SeatService();

        public void Execute()
        {
            int Number;

            Console.WriteLine("\n press 1 to log in \n press 2 to sign up,\n");
            string Option = Console.ReadLine().Trim();

            if (int.TryParse(Option, out Number))
            {
                switch (Number)
                {
                    case 1:
                        Console.Write("loggin in \n\n Username: ");
                        string AttemptedUsernameForLogIn = Console.ReadLine().Trim();

                        Console.Write("code: ");
                        string AttemptedCodeForLogIn= Console.ReadLine().Trim();

                        if (login.LogIn(AttemptedUsernameForLogIn, AttemptedCodeForLogIn))
                        {
                            Console.WriteLine("you've logged in");
                            ActualProgram();
                        }
                        else
                        {
                            Console.Write("you've not logged in, wrong username or code");
                        }
                        break;


                    case 2:
                        Console.Write("signing up \n\n Username: ");
                        string AttemptedUsernameForSignUp = Console.ReadLine().Trim();

                        Console.Write("code: ");
                        string AttemptedCodeForSigUp = Console.ReadLine().Trim();

                        if(login.SignUp(AttemptedUsernameForSignUp, AttemptedCodeForSigUp))
                        {
                            Console.WriteLine("Welcome "+ AttemptedUsernameForSignUp +"\n");
                            ActualProgram();
                        }
                        else
                        {
                            Console.WriteLine("unable to make user");
                        }
                        break;
                }
            }

            Console.ReadLine();
        } 

        public void ActualProgram()
        {
            Console.WriteLine("\n\n Welcome to the Cinema! We have a wide range of movies everyday, today it's ");

            while (true)
            {
                Console.Write("\n\n");

                foreach (var movie in MovieServise.SeeMovies())
                {
                    Console.WriteLine(movie.Number + ": " + movie.Name);
                }

                Console.Write(" if you want to see details about the movie, type in it's number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int MovieNumber))
                {
                    Movie SelectedMovie = MovieServise.SelectedMovie(MovieNumber);

                    Console.WriteLine("\n   " + SelectedMovie.Name + ": airs at: " + SelectedMovie.AiringTime.TimeOfDay + "\n    Takes " + SelectedMovie.PlayTime.Hours + " hours and " + SelectedMovie.PlayTime.Minutes + "minuts");

                    Console.WriteLine("\n There's " + SeatService.AllSeats().Count() + " seats. \n      would you like to reserve a seat? \n if you want the seat type in it's number:");
                    string ReserveOrNot = Console.ReadLine();

                    if (int.TryParse(ReserveOrNot.Trim().ToLower(), out int WishToReserve) && WishToReserve <= SeatService.AllSeats().Count())
                    {
                        if (SeatService.ReserveSeat(WishToReserve))
                        {
                            Console.WriteLine("seat nr:" + WishToReserve + " is now yours");
                        }
                        else
                        {
                            Console.WriteLine("the seat is already taken");
                        }
                    }
                    else
                    {
                        Console.WriteLine("not an avalible seatnumber");
                    }
                }
                else
                {
                    Console.WriteLine("that's not an option");
                }
            }
        }
    }
}
