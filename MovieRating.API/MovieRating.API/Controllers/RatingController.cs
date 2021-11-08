using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRating.API.Services;
using MovieRating.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MovieRating.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost]
        public async Task<IActionResult> Insert(RatingAddRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _ratingService.Insert(request, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
