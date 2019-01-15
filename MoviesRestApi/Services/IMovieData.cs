using MoviesRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRestApi.Services
{
    public interface IMovieData
    {
        IEnumerable<Movie> GetAll();
        //IQueryable<Movie> GetAll();
        Movie Get(int id);
        Movie Add(Movie movie);
        void Delete(int id);
        Movie Update(Movie movie);
    }
}
