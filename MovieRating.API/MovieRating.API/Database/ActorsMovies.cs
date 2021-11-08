using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRating.API.Database
{
    public class ActorsMovies
    {
        [ForeignKey("Actor_Id")]
        public Actors Actors { get; set; }

        public int Actor_Id { get; set; }

        [ForeignKey("Movie_Id")]
        public Movies Movies { get; set; }

        public int Movie_Id { get; set; }

    }
}
