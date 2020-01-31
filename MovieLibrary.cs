using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
   public class MovieLibrary
    {
        public List<Movie> Movies { get; set; }

        public MovieLibrary()
        {
            Movies = new List<Movie>();
        }

        public MovieLibrary(List<Movie> movies)
        {
            Movies = movies;
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }

        public void RemoveMovie(Movie movie)
        {
            Movies.Remove(movie);
        }

        public List<Movie> GetMovieByCategoryName(string category)
        {
            var returnList = new List<Movie>();

            foreach (var movie in Movies)
            {
                if (category == movie.Category)
                {
                    returnList.Add(movie);
                }
            }

            return returnList;
        }

        public List<Movie> GetMovieByCategoryNumber(int categoryNumber)
        {
            var returnList = new List<Movie>();

            foreach (var movie in Movies)
            {
                if (categoryNumber == movie.CategoryNumber)
                {
                    returnList.Add(movie);
                }
            }

            return returnList;
        }

        public List<string> GetMovieCategories()
        {
            var returnList = new List<String>();

            foreach (var movie in Movies)
            {
                returnList.Add(movie.Category);
            }
            return returnList;
        }
    }
}
