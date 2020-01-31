using System;
using System.Collections.Generic;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieList = new List<Movie>
            {
                new Movie("Star Wars","sci-fi", 1),
                new Movie("Pulp Fiction","action", 2),
                new Movie("Fight Club", "thriller", 3),
                new Movie("Scary Movie 3", "comedy", 4),
                new Movie("Indiana Jones","action", 2),
                new Movie("Star Trek","sci-fi", 1),
                new Movie("Airplane","comedy", 4)
            };

            // Here is an instance of movie library which has a list of Movies
            MovieLibrary library = new MovieLibrary(movieList);

            // Now you have access to everything you need to write to console
            // We do all of our writing to console here.  Movies shouldn't care if its information will be written to 
            // a file or to the console or over the internet.  That is the job of the User Interface (UI).

            // print all movie categories
            Console.WriteLine(library.GetMovieCategories());

            // I'll leave it up to you to do the actual implementation
            // I just really want you to understand the design part of what I'm trying explain

            List<Movie> movies = new List<Movie>
            {
                new Movie("Star Wars","sci-fi", 1),
                new Movie("Pulp Fiction","action", 2),
                new Movie("Fight Club", "thriller", 3),
                new Movie("Scary Movie 3", "comedy", 4),
                new Movie("Indiana Jones","action", 2),
                new Movie("Star Trek","sci-fi", 1),
                new Movie("Airplane","comedy", 4)
            };
            bool resume = false; 
            do
            {
                try
                {
                    Movie.ShowMovieMenu(movies);
                    Console.WriteLine();
                    Movie.ShowCategoryMenu(movies);
                    Console.WriteLine();
                    Console.WriteLine();
                    int userChoice = int.Parse(GetUserInput("Which category would you like to see?"));
                    Movie.ShowMoviesByCategories(movies, userChoice);
                    resume = AskToTryAgain(GetUserInput("Would you like to try again? (y/n)"));

                    
                }
                catch (FormatException)
                {
                    resume = AskToTryAgain(GetUserInput("Wrong input. Try Again? (y/n)"));
                }
                
            } while (resume == true);
            


        }

        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static bool AskToTryAgain(string input)
        {
            try
            {
                if (input.ToLower()[0] == 'y')
                {
                    return true;
                }
                else if (input.ToLower()[0] == 'n')
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Wrong input. Would you like to try again? (y/n)");
                    string input2 = Console.ReadLine();
                    AskToTryAgain(input2);
                }

            }
            catch (StackOverflowException)
            {

                string userError = GetUserInput("That's not right. Try again: 'y' or 'n'");
                AskToTryAgain(userError);
            }

            return true;

        }





    }
}
