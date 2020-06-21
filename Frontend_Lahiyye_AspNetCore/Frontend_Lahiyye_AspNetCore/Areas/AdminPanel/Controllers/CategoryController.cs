using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Frontend_Lahiyye_AspNetCore.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        [Area("AdminPanel")]
        public IActionResult Index()
        {

            return View(_db.Categories);
        }
        [Area("AdminPanel")]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = await _db.Categories.FindAsync(id);
            if (category == null)
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
        [HttpPost, Area("AdminPanel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool IsValid = _db.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (IsValid)
            {
                ModelState.AddModelError("Name", "Bu adli kategory movcuddur");
                return View();
            }
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        //[Area("AdminPanel")]
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id==null)
        //    {
        //        return NotFound();
        //    }
        //   Category category=await _db.Categories.FindAsync(id);
        //    if (category==null)
        //    {
        //        return NotFound();
        //    }
        //    return View(category);
        //}
        //public async Task <IActionResult> Edit(int? id,Category category)
        //{
        //    if (ModelState.IsValid) return View();
        //    if (id == null) return NotFound();
        //    Category dbCategory =await _db.Categories.FindAsync(id);
        //    Category chekdCategory = _db.Categories.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());
        //    if (dbCategory.Id!= chekdCategory.Id)
        //    {
        //        ModelState.AddModelError("Name", "Bu adli kategory movcuddur");
        //        return View();

        //    }
        //    dbCategory.Name = category.Name;
        //    dbCategory.Description = category.Description;
        //    await _db.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));


        //}
        [Area("AdminPanel")]
        public async Task<IActionResult> Delet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = await _db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();

            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delet")]
        [Area("AdminPAnel")]
        
        public async Task<IActionResult> DeletPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category category = await _db.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();

            }
            _db.Categories.Remove(category);
           await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
