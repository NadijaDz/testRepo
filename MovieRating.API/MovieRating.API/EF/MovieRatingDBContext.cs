using Microsoft.EntityFrameworkCore;
using MovieRating.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRating.API
{
    public partial class MovieRatingDBContext:DbContext
    {
        public MovieRatingDBContext(DbContextOptions<MovieRatingDBContext> options)
         : base(options)
        {
        }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<ActorsMovies> ActorsMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorsMovies>().HasKey(sc => new { sc.Actor_Id, sc.Movie_Id });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
