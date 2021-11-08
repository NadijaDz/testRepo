using AutoMapper;
using MovieRating.API.Database;
using MovieRating.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRating.API.Mapping
{
    public class MovieRatingProfile: Profile
    {
        public MovieRatingProfile()
        {
            CreateMap<Movies, MoviesGetDto>();

            CreateMap<Rating, RatingGetDto>();
            CreateMap<Rating, RatingAddRequest>().ReverseMap();

        }
    }
}
