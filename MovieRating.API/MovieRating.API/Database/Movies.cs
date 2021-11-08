using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRating.API.Database
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CoverImage { get; set; }

        public DateTime RelaseDate { get; set; }

        public string TypeMovie { get; set; }

        public virtual ICollection<Rating> MovieRatings { get; set; }

    }
}
