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
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isValid = _db.Categories.Any(c => c.Name == category.Name);
            if (isValid)
            {
                ModelState.AddModelError("Name","Bu adda categoria movcutdur");
                return View();
            }
            _db.Categories.Add(category);
           await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
            //return Content($"{category.Name} {category.Description}");
        }
        [Area("AdminPanel")]
        public async Task <IActionResult> Edit(int? id )
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
        [HttpPost,Area("AdminPanel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null)
            {
                return NotFound();
            }
            Category dbcategory = await _db.Categories.FindAsync(id);
            Category checkCatgegoey = _db.Categories.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());

            if (checkCatgegoey!=null)
            {
                if (dbcategory.Id != checkCatgegoey.Id)
                {
                    ModelState.AddModelError("Name", "Bu adli categoria movcutdur !!");
                    return View();
                }

            }
            dbcategory.Name = category.Name;
            dbcategory.Description = category.Description;
          await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [Area("AdminPanel")]
        public async Task<IActionResult> Delet(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Category category = await _db.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);

        }
        [HttpPost,Area("AdminPanel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delet(int? id,Category category)
        {
            if (id==null)
            {
                return NotFound();
            }
            Category FindcategoryId = await _db.Categories.FindAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            _db.Categories.Remove(FindcategoryId);
           await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
