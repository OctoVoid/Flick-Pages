using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flick_Pages
{
    class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Runtime { get; set; }
        public string Language { get; set; }
        public int Rating { get; set; }

    }
}
