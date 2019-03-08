using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name ="Genre Type")]
        public short GenreTypeId { get; set; }

        [StringLength(10)]
        [Display(Name = "Date of Release")]
        public string ReleasedDate { get; set; }

        [Display(Name = "Number In Stock")]
        public short Quantity { get; set; }
    }
}