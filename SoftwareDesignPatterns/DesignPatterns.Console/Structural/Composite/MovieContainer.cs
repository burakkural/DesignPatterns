using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Composite
{
    public class MovieContainer : IMovie
    {
        private List<IMovie> movies = new List<IMovie>();

        public void AddMovie(IMovie movie)
        {
            this.movies.Add(movie);
        }

        public void RemoveMovie(IMovie movie)
        {
            this.movies.Remove(movie);
        }

        public void ShowMovieInfo()
        {
            foreach (IMovie movie in this.movies)
            {
                movie.ShowMovieInfo();
            }
        }
    }
}
