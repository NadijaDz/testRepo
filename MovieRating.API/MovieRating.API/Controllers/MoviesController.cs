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
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService _moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [Route("GetMoviesByRating")]
        [HttpGet]
        public async Task<IActionResult> GetMoviesByRating([FromQuery] SearchParametersModel param,CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _moviesService.GetMoviesByRating(param, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
       
       [Route("GetAllMoviesForRate")]
       [HttpGet]
        public async Task<IActionResult> GetAllMoviesForRate(CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _moviesService.GetAllMoviesForRate(cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
