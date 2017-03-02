using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidlyr.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RelaseDateTime { get; set; }
        public DateTime AddeDateTime { get; set; }
        public int Stock { get; set; }
        public Genre Genre { get; set; }


    }
}