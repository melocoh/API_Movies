using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_WebAPI_Application.Models
{
    public class Movie
    {

        [Key]
        public int MovieId { get; set; }

        public string Title { get; set; }

        public string ReleaseYear { get; set; }
    }
}
