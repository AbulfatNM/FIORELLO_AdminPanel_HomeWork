using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Models;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public HeaderViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task <IViewComponentResult> InvokeAsync()
        {
            var model = _db.Bios.FirstOrDefault();
            ViewBag.basketProdCount = 0;
            ViewBag.basketProdPrice = 0;
            if(User.Identity.IsAuthenticated)
             {
                AppUser loginUser =await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.LoginUser = loginUser.FullName;
               }
            string basket = Request.Cookies["basket"];
            if (Request.Cookies["basket"]!=null)
            {
               List<BasketProductVM> basketProductVM= JsonConvert.DeserializeObject<List<BasketProductVM>>(basket);
                ViewBag.basketProdCount = basketProductVM.Sum(c => c.Count);
                ViewBag.basketProdPrice = 0;

                foreach (BasketProductVM item in basketProductVM)
                {
                    ViewBag.basketProdPrice = item.Price * ViewBag.basketProdCount;
                }
             
            }

            return View(await Task.FromResult(model));
        }

    }
}
