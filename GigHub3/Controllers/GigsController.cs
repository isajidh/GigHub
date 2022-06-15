using GigHub3.Models;
using GigHub3.ViewModel;
using Microsoft.AspNet.Identity;
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(GigFormVM gigViewModel)
        {
            if (!ModelState.IsValid)
            {
                gigViewModel.Genres = db.Genres.ToList();
                return View("Create", gigViewModel);
            }

            Gig gig = new Gig
            {
                ArtistID = User.Identity.GetUserId(),
                DateTime = gigViewModel.GetDateTime(),
                GenreID = gigViewModel.Genre,
                Venue = gigViewModel.Venue
            };

            db.Gigs.Add(gig);
            db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}