using MovieApp.Data;
using MovieApp.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

namespace MovieApp.UI
{
    class Program
    {
        static void Adder()
        {
            var context = new MovieContext();

            var a1 = new Actor
            {
                Name = "Japp Friske",
                Birthday = new DateTime(1972, 10, 15),
                Nationality = "British"
            };

            var a2 = new Actor
            {
                Name = "Else Hampe",
                Birthday = new DateTime(1979, 3, 24),
                Nationality = "German"
            };

            var actors = new List<Actor> { a1, a2 };

            var movie = new Movie
            {
                Title = "En dag var jaga bara rik",
                ReleaseDate = new DateTime(2003, 4, 25),
                Actors = actors
            };

            context.Movies.Add(movie);
            context.SaveChanges();
        }

        static void Printer()
        {
            var context = new MovieContext();
            var movies = context.Movies
                .Include("Actors")
                .ToList();

            var movies2 = context.Movies
                .Include(m => m.Actors)
                .ToList();

            foreach(var movie in movies)
            {
                Console.WriteLine(movie.Title);
                foreach(var actor in movie.Actors)
                {
                    Console.WriteLine("\t" + actor.Name);
                }
            }
        }

        static void Main(string[] args)
        {
            //Adder();
            Printer();
        }
    }
}
