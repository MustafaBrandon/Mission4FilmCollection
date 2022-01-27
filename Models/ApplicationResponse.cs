using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int FilmId { get; set; }
        [Required]
        public string FilmTitle { set; get; }
        [Required]
        public string Category{ set; get; }
        [Required]
        public int FilmYear { set; get; }
        [Required]
        public string FilmDirector { set; get; }
        [Required]
        public string FilmRating { get; set; }

        public bool Edited { get; set;  }

        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }

    }
}
