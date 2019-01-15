using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRestApi.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

    }
}
