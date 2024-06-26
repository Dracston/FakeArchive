﻿using System.ComponentModel.DataAnnotations;

namespace FakeArchive.Models
{
    public class Movie
    {

        public int movieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public string MovieFormat { get; set; }

        [Required]
        public string Director { get; set; }


    }
}
