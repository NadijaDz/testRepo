using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating.Model.Models
{
    public class RatingGetDto
    {
        public int Id { get; set; }

        public int Rate { get; set; }

        public int Movie_Id { get; set; }
    }
}
