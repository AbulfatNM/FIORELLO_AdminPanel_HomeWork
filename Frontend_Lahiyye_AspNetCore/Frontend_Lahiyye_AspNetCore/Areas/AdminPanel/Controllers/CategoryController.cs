using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Frontend_Lahiyye_AspNetCore.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db=db;
        }
        [Area("AdminPanel")]
        public IActionResult Index()
        {
           
            return View(_db.Categories);
        }
        [Area("AdminPanel")]
        public async Task <IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Category category =await _db.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        [Area("AdminPanel")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost,Area("AdminPanel")]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return Content($"{category.Name} {category.Description}");
        }
    }
}
