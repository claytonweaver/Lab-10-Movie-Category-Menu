using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
    public class Movie
    {
        // private class members should always start with '_'
        bool propertyName;
        private string _title;
        private string _category;
        private int _categoryNumber;
        
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public int CategoryNumber
        {
            get { return _categoryNumber; }
            set { _categoryNumber = value; } 
        }
        public Movie()
        {

        }

        // method parameters should always be camelCase
        public Movie(string title, string category, int categoryNumber)
        {
            _title = title;
            _category = category;
            _categoryNumber = categoryNumber;
        }


        // These methods don't belong here.  You could have a movie library class that holds a list of movies
        // and has methods like GetMovieList or GetMoviesByCategory.
        // I think this is a key concept to understand.  

        // Static methods or members in a class have a special use case.  Using them like this kind of defeats the purpose
        // of a class

        private static List<string> GetListofMovieCategories(List<Movie> movieList)
        {
            List<string> movieCategories = new List<string>();
            foreach (var movie in movieList)
            {
                if (!movieCategories.Contains(movie._category))
                {
                    movieCategories.Add(movie._category);
                }
            }
            return movieCategories;
        }


        // You have to think about classes like this as only containing information about movies or actions on movies
        // Movies should never know anything about the User Interface.  User interface interaction has to be done in the
        // user interface layer, in this case the Program.cs
        public static void ShowMoviesByCategories(List<Movie> movies, int userNumber)
        {
            foreach (var movie in movies)
            {
                if (userNumber == movie._categoryNumber)
                {
                    Console.WriteLine($"{movie._title} - {movie._category}");
                }
            }
        }
        public static void ShowMovieMenu(List<Movie> movies)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i]._title} ({movies[i]._category})");

            }
        }
        public static void ShowCategoryMenu(List<Movie> movies)
        {
            List<string> movieCategories = new List<string>(GetListofMovieCategories(movies));
            for (int i = 1; i < movieCategories.Count + 1; i++)
            {
                Console.Write($"{i}) {movieCategories[i-1]} ");
               
            }
        }
    }
}
