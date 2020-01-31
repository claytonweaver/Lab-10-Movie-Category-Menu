using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
    class Movie
    {
        private string title;
        private string category;
        private int categoryNumber;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int CategoryNumber
        {
            get { return categoryNumber; }
            set { categoryNumber = value; } 
        }
        public Movie()
        {

        }

        public Movie(string _title, string _category, int _categoryNumber)
        {
            title = _title;
            category = _category;
            categoryNumber = _categoryNumber;
        }

        private static List<string> GetListofMovieCategories(List<Movie> movieList)
        {
            List<string> movieCategories = new List<string>();
            foreach (var movie in movieList)
            {
                if (!movieCategories.Contains(movie.category))
                {
                    movieCategories.Add(movie.category);
                }
            }
            return movieCategories;
        }

        public static void ShowMoviesByCategories(List<Movie> movies, int userNumber)
        {
            foreach (var movie in movies)
            {
                if (userNumber == movie.categoryNumber)
                {
                    Console.WriteLine($"{movie.title} - {movie.category}");
                }
            }
        }
        public static void ShowMovieMenu(List<Movie> movies)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].title} ({movies[i].category})");

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
