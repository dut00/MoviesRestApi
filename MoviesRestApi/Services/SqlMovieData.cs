using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesRestApi.Data;
using MoviesRestApi.Models;

namespace MoviesRestApi.Services
{
    public class SqlMovieData : IMovieData
    {
        private MoviesRestApiDbContext _context;

        public SqlMovieData(MoviesRestApiDbContext context)
        {
            _context = context;
        }

        public Movie Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }

        public void Delete(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(r => r.MovieID == id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public Movie Get(int id)
        {
            return _context.Movies.FirstOrDefault(r => r.MovieID == id);
        }

        public IEnumerable<Movie> GetAll()
        //public IQueryable<Movie> GetAll()
        {
            return _context.Movies.OrderBy(r => r.MovieID);
        }

        public Movie Update(Movie movie)
        {
            _context.Attach(movie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return movie;
        }
    }
}
