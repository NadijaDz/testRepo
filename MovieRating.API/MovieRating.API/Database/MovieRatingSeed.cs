
using Microsoft.EntityFrameworkCore;
using MovieRating.API.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MovieRating.API
{
    public partial class MovieRatingDBContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            var json = Path.Combine(Directory.GetCurrentDirectory(), "Movies.json");
            StreamReader r = new StreamReader(json);
            string jsonString = r.ReadToEnd();
            var stuff = JsonConvert.DeserializeObject<List<Movies>>(jsonString);

            foreach(var m in stuff)
            {

                MovieRating.API.Database.Movies movie = new MovieRating.API.Database.Movies()
                {
                    Id = m.Id,
                    Title = m.Title,
                    Description = m.Description,
                    CoverImage = m.CoverImage,
                    RelaseDate = new DateTime(new Random().Next(2000, 2021), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0),
                TypeMovie = m.TypeMovie

                };
                modelBuilder.Entity<Movies>().HasData(movie);

            }

            List<Actors> actors = new List<Actors>()
            {
                new Actors{Id=1,FirstName="Meryl", LastName="Streep", Gender="Female", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=2,FirstName="Margot", LastName="Robbie", Gender="Female", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=3,FirstName="Lupita", LastName="Nyong'o", Gender="Female", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=4,FirstName="Johnny", LastName="Depp", Gender="Male", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=5,FirstName="Robert", LastName="De Niro", Gender="Male", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=6,FirstName="Al", LastName="Pacino", Gender="Male", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=7,FirstName="Kevin", LastName="Spacey", Gender="Male", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=8,FirstName="Denzel", LastName="Washington", Gender="Male", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=9,FirstName="Angelina", LastName="Jolie", Gender="Female", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},
                new Actors{Id=10,FirstName="Tom", LastName="Cruise", Gender="Male", Birthday = new DateTime(new Random().Next(1950, 2010), new Random().Next(1, 12), new Random().Next(1, 28),0,0,0)},

            };

            modelBuilder.Entity<Actors>().HasData(actors);

            int movieID = 1;
            List<ActorsMovies> actorsMovies = new List<ActorsMovies>();

            foreach (var m in stuff)
            {
                int actorID1 = new Random().Next(1, 10);
                int actorID2 = new Random().Next(1, 10);
                while (actorID1 == actorID2)
                {
                    actorID2 = new Random().Next(1, 10);
                }

                actorsMovies.Add(new ActorsMovies { Actor_Id = actorID1, Movie_Id = movieID });
                actorsMovies.Add(new ActorsMovies { Actor_Id = actorID2, Movie_Id = movieID });
                movieID++;
            }
            modelBuilder.Entity<ActorsMovies>().HasData(actorsMovies);

        }
    }
}
