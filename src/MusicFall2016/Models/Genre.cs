﻿using System.ComponentModel.DataAnnotations;

namespace MusicFall2016.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [Required(ErrorMessage="Please enter in a name.")]
        public string Name { get; set; }
    }
}