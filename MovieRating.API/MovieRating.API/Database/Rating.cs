using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRating.API.Database
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        public int Rate { get; set; }
   
        [ForeignKey("Movie_Id")]
        public Movies Movies { get; set; }

        public int Movie_Id { get; set; }

    }
}
