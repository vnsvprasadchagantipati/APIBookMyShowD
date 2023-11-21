using APIBookMyShowD.Entities;
using APIBookMyShowD.Repository;
using APIBookMyShowD.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace APIBookMyShowD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public readonly IMovieService movieService;

        public MovieController()
        {
            movieService = new MovieService();
        }
        [HttpGet, Route("GetAllMovies")]
        [AllowAnonymous]
        public IActionResult GetAllMovies()
        {

            try
            {
                List<Movie> movies = movieService.GetAllMovies();
                return StatusCode(200, movies);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("AddMovie")]
        [Authorize(Roles = "Admin")]
        public IActionResult Add([FromBody] Movie movie)
           
        {
            try
            {
                movieService.CreateMovie(movie);
                return StatusCode(200, movie);
            }
            catch (Exception)
            {

                throw;
            }

        }
        //delete /delete 
        [HttpDelete, Route("deleteMovie/{MovieId}")]
        [Authorize(Roles = "Admin")]

        public IActionResult Delete([FromBody] string movieId)
        {

            try
            {

                movieService.DeleteMovie(movieId);
                return StatusCode(200, new JsonResult($"City with Id {movieId} is deleted"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
       



    } }


