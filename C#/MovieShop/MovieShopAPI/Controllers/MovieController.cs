using Core.Contracts.Service;
using Core.Entities;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace MovieShopAPI.Controllers
{
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServiceAsync movieService;
        private readonly ITrailerServiceAsync trailerService;
        private readonly IGenreServiceAsync genreService;
        public MovieController(IMovieServiceAsync movieService,
            ITrailerServiceAsync trailerService,
            IGenreServiceAsync genreService)
        {
            this.movieService = movieService;
            this.trailerService = trailerService;
            this.genreService = genreService;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAll()
        {
            var r = await movieService.GetAllMoviesAsync();
            return Ok(r);
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var r = await movieService.GetMovieByIdAsync(id);
            return Ok(r);
        }

        [HttpGet]
        [Route("getG/{genreName}")]
        public async Task<IActionResult> GetByGenre(string genreName)
        {
            var r = await movieService.
        }

        [HttpGet]
        [Route("trailers/{movieId}")]
        public async Task<IActionResult> GetTrailers(int movieId)
        {
            var r = await trailerService.GetTrailerByMovie(movieId);
            return Ok(r);
        }

        [HttpGet]
        [Route("genre/{movieId}")]
        public async Task<IActionResult> GetGenres(int movieId)
        {
            var r = await genreService.getAllGenresByMovie(movieId);
            return Ok(r);
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> Post([FromBody] Movie movie)
        {
            var r = await movieService.InsertMovieAsync(movie);
            return Ok(r);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var r = await movieService.DeleteMovieByIdAsync(id);
            return Ok(r);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] Movie movie)
        {
            var r = await movieService.UpdateMovieAsync(movie);
            return Ok(r);
        }
    }
}
