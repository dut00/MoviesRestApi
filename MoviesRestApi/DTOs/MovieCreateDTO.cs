﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRestApi.DTOs
{
    public class MovieCreateDTO
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }
    }
}
