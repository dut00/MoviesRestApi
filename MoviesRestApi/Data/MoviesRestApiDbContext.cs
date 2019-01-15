using Microsoft.EntityFrameworkCore;
using MoviesRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRestApi.Data
{
    public class MoviesRestApiDbContext : DbContext
    {
        public MoviesRestApiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
