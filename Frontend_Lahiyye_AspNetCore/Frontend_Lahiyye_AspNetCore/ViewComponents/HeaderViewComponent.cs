using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task <IViewComponentResult> InvokeAsync()
        {
            var model = _db.Bios.FirstOrDefault();
            string basket = Request.Cookies["basket"];
            ViewBag.BasketCount = 0;
            ViewBag.BasketPrice = 0;
            if (basket != null)
            {
                List<BasketVM> basketsProduct = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                ViewBag.BasketCount = basketsProduct.Sum(c => c.Count);
                
                foreach (BasketVM item in basketsProduct)
                {

                    ViewBag.BasketPrice = ViewBag.BasketCount * item.Price;
                }
            }
            return View(await Task.FromResult(model));
        }

    }
}
