using AutoMapper;
using MovieRating.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRating.API.Services
{
    public interface IRatingService
    {
        Task<RatingGetDto> Insert(RatingAddRequest request, CancellationToken cancellationToken);
    }
    public class RatingService : IRatingService
    {
        private readonly MovieRatingDBContext _context;
        protected readonly IMapper _mapper;

        public RatingService(MovieRatingDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RatingGetDto> Insert(RatingAddRequest request, CancellationToken cancellationToken)
        {

            var entity = _mapper.Map<Database.Rating>(request);
            _context.Rating.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<RatingGetDto>(entity);
        }
    }
}
