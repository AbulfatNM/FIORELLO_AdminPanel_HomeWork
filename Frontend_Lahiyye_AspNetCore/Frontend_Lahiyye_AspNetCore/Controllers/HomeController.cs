using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Frontend_Lahiyye_AspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = _db.Sliders,
                Content = _db.Contents.FirstOrDefault(),
                Categories = _db.Categories,
                //Products = _db.Products

            };

            return View(homeVM);
        }
    }
}
