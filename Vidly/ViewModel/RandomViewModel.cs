using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class RandomViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}