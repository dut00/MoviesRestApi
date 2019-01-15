using Microsoft.AspNetCore.Mvc;
using MoviesRestApi.DTOs;
using MoviesRestApi.Models;
using MoviesRestApi.Services;
using System.Collections.Generic;

namespace MoviesRestApi.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieData _movieData;

        public MoviesController(IMovieData movieData)
        {
            _movieData = movieData;
        }

        // GET api/movies
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movieData.GetAll();
        }

        // GET api/movies/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return _movieData.Get(id);
        }

        // POST api/movies
        [HttpPost]
        public void Post([FromBody] MovieCreateDTO movieDto)
        {
            var movie = new Movie();

            movie.Title = movieDto.Title;
            movie.Year = movieDto.Year;

            _movieData.Add(movie);

            //try
            //{

            //}
            //catch (System.Exception)
            //{

            //    throw;
            //}
        }

        // PUT api/movies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MovieCreateDTO movieDto)
        {
            var movie = new Movie();

            movie.MovieID = id;
            movie.Title = movieDto.Title;
            movie.Year = movieDto.Year;

            _movieData.Update(movie);
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _movieData.Delete(id);
        }
    }
}
