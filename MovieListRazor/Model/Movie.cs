using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListRazor.Model
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Genre { get; set; }

        public string IMDbURL { get; set; }
    }
}
