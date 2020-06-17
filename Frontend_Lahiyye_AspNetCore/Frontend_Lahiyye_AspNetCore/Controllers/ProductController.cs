using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Frontend_Lahiyye_AspNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.ProductCount = _db.Products.Count();
            return View(_db.Products.Select(p=> new ProductVM {
            Id=p.Id,
            Price=p.Price,
            Title=p.Title,
            Image=p.Image
            }).Take(4));
        }
        public IActionResult Load( int skip)
        {
            var vmModel = _db.Products.Select(p => new ProductVM
            {
                Id = p.Id,
                Price = p.Price,
                Title = p.Title,
                Image = p.Image
            }).Skip(skip).Take(4);
            return PartialView("_ProductPartial", vmModel);

            #region Old Version
            //return Json(_db.Products.Select(p => new ProductVM
            //{
            //    Id = p.Id,
            //    Price = p.Price,
            //    Title = p.Title,
            //    Image = p.Image
            //}).Skip(4).Take(4));
            #endregion



        }
    }
}
