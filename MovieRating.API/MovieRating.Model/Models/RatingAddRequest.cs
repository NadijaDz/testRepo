using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating.Model.Models
{
    public class RatingAddRequest
    {
        public int Rate { get; set; }

        public int Movie_Id { get; set; }
    }
}
