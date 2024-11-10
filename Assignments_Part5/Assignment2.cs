using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
    }
    public class MovieLibrary
    {
        public Movie[] Movies=new Movie[4];
        private int currentIndex = 0;

        public void AddMovie(Movie movie)
        {
            Movies[currentIndex] = movie;
            currentIndex++;
        }
        public void DisplayMovies() 
        {
            try
            {
                foreach (var movie in Movies)
                {

                    Console.WriteLine($"Title:{movie.Title}, Year:{movie.Year}");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
