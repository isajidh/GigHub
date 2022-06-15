using GigHub3.Models;
using GigHub3.ViewModel;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GigHub3.Controllers
{
    public class GigsController : Controller
    {

        private readonly ApplicationDbContext db;
        public GigsController()
        {
            db = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            GigFormVM gigViewModel = new GigFormVM
            {
                Genres = db.Genres.ToList()
            };

            return View(gigViewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(GigFormVM gigViewModel)
        {

            Gigs gig = new Gigs
            {
                ArtistID = User.Identity.GetUserId(),
                DateTime = gigViewModel.DateTime,
                GenreID = gigViewModel.Genre,
                Venue = gigViewModel.Venue
            };

            db.Gig.Add(gig);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}