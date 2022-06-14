﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub3.Models
{
    public class Gig
    {

        public int ID { get; set; }

        [Required()]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required()]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required()]
        public Genre Genre { get; set; }
    }
}