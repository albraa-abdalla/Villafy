﻿using System.ComponentModel.DataAnnotations;

namespace VillaWeb.Models.Dto.Villa
{
    public class VillaUpdateDto
    {
        public int VillaId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]

        public int Occupancy { get; set; }
        [Required]

        public int Sqft { get; set; }
        [Required]

        public double Rate { get; set; }
        [Required]

        public string ImageUrl { get; set; }

        public string Amenity { get; set; }
    }
}
