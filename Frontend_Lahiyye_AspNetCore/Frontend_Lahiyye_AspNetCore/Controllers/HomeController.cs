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
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
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

        public async Task <IActionResult> AddBasket(int? id)
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
            List<BasketProductVM> products;
            if (Request.Cookies["basket"]==null)
            {
                  products = new List<BasketProductVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketProductVM>>(Request.Cookies["basket"]);
            }
            BasketProductVM checkProduct = products.FirstOrDefault(p => p.Id == id);
            if (checkProduct==null)
            {
                BasketProductVM basketProductVM = new BasketProductVM()
                {
                    Id = product.Id,
                    Image = product.Image,
                    Price = product.Price,
                    Title = product.Title,
                    Count = 1
                };
                products.Add(basketProductVM);
            }
            else
            {
                checkProduct.Count++;
            }
            string basket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(15) });
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Basket()
        {
            List<BasketProductVM> productVM;
            if (Request.Cookies["basket"] != null)
            {
                productVM = JsonConvert.DeserializeObject<List<BasketProductVM>>(Request.Cookies["basket"]);
            }
            else
            {
                return NotFound();
            }

            return View(productVM);
            //BasketProductVM product = productVMs.FirstOrDefault(p => p.Id == 1);
            //productVMs.Remove(product);
        }
        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            List<BasketProductVM> basketProducts =JsonConvert.DeserializeObject<List<BasketProductVM>>(Request.Cookies["basket"]);
            BasketProductVM findIdProduct = basketProducts.FirstOrDefault(p => p.Id == id);
            if (findIdProduct.Count==1)
            {
                basketProducts.Remove(findIdProduct);
            }
            else
            {
                findIdProduct.Count--;
            }
            string removeProduct = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("basket", removeProduct, new CookieOptions { MaxAge = TimeSpan.FromDays(15) });
            return RedirectToAction(nameof(Basket)); 
        }
     
    }
}
