using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating.Model.Models
{
   public class MoviesGetDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CoverImage { get; set; }

        public DateTime RelaseDate { get; set; }

        public string TypeMovie { get; set; }

        public double? AverageRate { get; set; }

    }
}
