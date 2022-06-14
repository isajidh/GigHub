using GigHub3.Models;
using GigHub3.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace GigHub3.Controllers
{
    public class GigsController : Controller
    {

        private readonly ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }


        public ActionResult Create()
        {
            GigFormVM viewModel = new GigFormVM
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }
    }
}