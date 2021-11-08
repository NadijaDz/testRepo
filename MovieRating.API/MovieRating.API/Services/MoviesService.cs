using AutoMapper;
using MovieRating.API.Database;
using MovieRating.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRating.API.Services
{
    public interface IMoviesService
    {
        Task<PaginationModel<IEnumerable<MoviesGetDto>>> GetMoviesByRating(SearchParametersModel param, CancellationToken cancellationToken);
        Task<List<MoviesGetDto>> GetAllMoviesForRate(CancellationToken cancellationToken);
    }

    public class MoviesService : IMoviesService
    {
        private readonly MovieRatingDBContext _context;
        protected readonly IMapper _mapper;

        public MoviesService(MovieRatingDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginationModel<IEnumerable<MoviesGetDto>>> GetMoviesByRating(SearchParametersModel param, CancellationToken cancellationToken)
        {
            var listofMoviesDescAverage = _context.Movies
              .OrderByDescending(m => m.MovieRatings.Average(r => r.Rate))
              .Where(g => g.TypeMovie.Equals(param.TypeMovie)
                                            && ((string.IsNullOrWhiteSpace(param.SearchQuery)
                                            || g.Title.ToLower().Trim().StartsWith(param.SearchQuery.ToLower().Trim()))
                                            || (string.IsNullOrWhiteSpace(param.SearchQuery)
                                            || g.Description.ToLower().Trim().StartsWith(param.SearchQuery.ToLower().Trim())))
                                            );

            var countAllMovies = _context.Movies.Where(g => g.TypeMovie.Equals(param.TypeMovie)).Count();
            
            listofMoviesDescAverage = listofMoviesDescAverage.Skip(param.SkipItems).Take(10);

            var data = _mapper.Map<List<MoviesGetDto>>(listofMoviesDescAverage);

            return new PaginationModel<IEnumerable<MoviesGetDto>>(data, countAllMovies);
        }

        public async Task<List<MoviesGetDto>> GetAllMoviesForRate(CancellationToken cancellationToken)
        {
            var listofMoviesDescAverageForRate = _context.Movies
              .OrderByDescending(m => m.MovieRatings.Average(r => r.Rate))
              .Select(x => new MoviesGetDto
              {
                  Id = x.Id,
                  Title = x.Title,
                  AverageRate = x.MovieRatings.Average(a => a.Rate),
                  Description = x.Description,
                  CoverImage = x.CoverImage,
                  RelaseDate = x.RelaseDate
              });

            return _mapper.Map<List<MoviesGetDto>>(listofMoviesDescAverageForRate);
        }

    }
}
