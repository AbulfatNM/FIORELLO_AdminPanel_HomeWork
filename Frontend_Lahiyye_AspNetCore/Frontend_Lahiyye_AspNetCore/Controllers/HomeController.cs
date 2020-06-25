using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Models;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Adapter.Internal;
using Newtonsoft.Json;

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
        public async Task<IActionResult> Addbasket(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Product product = await _db.Products.FindAsync(id);
          
            if (product==null)
            {
                return NotFound();
            }
            List<BasketVM> products;
            if (Request.Cookies["basket"]==null)
            {
                products= new List<BasketVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
            }
            BasketVM checkProducts = products.FirstOrDefault(p => p.Id == id);
            if (checkProducts==null)
            {
                BasketVM basketVM = new BasketVM()
                {
                    Id = product.Id,
                    Image = product.Image,
                    Price = product.Price,
                    Title = product.Title,
                    Count = 1
                };
                products.Add(basketVM);

            }
            else
            {
                checkProducts.Count++;
            }
      
            string basket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket",basket, new CookieOptions {MaxAge=TimeSpan.FromDays(15)});
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Basket()
        {
            return Content(Request.Cookies["basket"]);
        }

   

    }
}
