using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating.Model.Models
{
   public class SearchParametersModel
    {
        public string TypeMovie { get; set; }

        public string SearchQuery { get; set; }

        public int SkipItems { get; set; }

    }
}
