using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlyr.Models;
using Vidlyr.ViewModel;
using System.Data.Entity;

namespace Vidlyr.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context =new ApplicationDbContext();
        }

        protected override void Dispose(bool disposed)
        {
            _context.Dispose();
        }
        // GET: Movies/
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
         }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }
       

    }
}