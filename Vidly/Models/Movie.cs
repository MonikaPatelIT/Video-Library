using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Genre Genre { get; set; }
        public string GenreType { get; set; }
        public string ReleasedDate { get; set; }
        public short Quantity { get; set; }
    }
}