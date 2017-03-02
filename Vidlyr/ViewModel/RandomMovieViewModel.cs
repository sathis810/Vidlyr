using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidlyr.Models;

namespace Vidlyr.ViewModel
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}