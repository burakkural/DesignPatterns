using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.Structural.Composite
{
    public class Thriller : IMovie
    {
        private readonly int id;
        private readonly string name;
        private readonly string relaseDate;
        private readonly double imdb;

        public Thriller(int id,string name,string relaseDate,double imdb)
        {
            this.id = id;
            this.name = name;
            this.relaseDate = relaseDate;
            this.imdb = imdb;
        }
        public void ShowMovieInfo()
        {
            System.Console.WriteLine("Film adı     : " + name);
            System.Console.WriteLine("Yayın Tarihi : " + relaseDate);
            System.Console.WriteLine("Imdb         : " + imdb);
            System.Console.WriteLine(new string('-',30));
        }
    }
}
