using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Extensions;
using Frontend_Lahiyye_AspNetCore.Helpers;
using Frontend_Lahiyye_AspNetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;


namespace Frontend_Lahiyye_AspNetCore.Areas.AdminPanel.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        [Area("AdminPanel")]
        public IActionResult Index()
        {
            ViewBag.SliderCount = _db.Sliders.Count();
            return View(_db.Sliders);
        }
        [Area("AdminPanel")]
        public async Task <IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Slider slide =await _db.Sliders.FindAsync(id);
            if (slide==null)
            {
                return NotFound();
            }
           
            return View(slide);
        }
        [Area("AdminPanel")]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost,Area("AdminPanel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (slider.Photo.IsValidImg())
            {
                ModelState.AddModelError("Photo","Zehmet olmasa sekil secin");
                return View();
            }
            if (slider.Photo.MaxLenght(200))
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa 200 kbtden az sekil secin ");
                return View();
            }
            int sliderCount=_db.Sliders.Count();
            if (sliderCount >= 5)
            {
                ModelState.AddModelError("", "5 weklden cox elave edile bilmez");
                return View();
            }
            slider.Image = await slider.Photo.CopyImage(_env.WebRootPath,"images");
            await _db.Sliders.AddAsync(slider);
           await   _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        [Area("AdminPanel")]
        public async Task <IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider slide = await _db.Sliders.FindAsync(id);
            if (slide == null)
            {
                return NotFound();
            }
            return View(slide);

        }
        [HttpPost,Area("AdminPanel")]
        [ValidateAntiForgeryToken,ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider==null)
            {
                return NotFound();
            }
              Helper.DeleteImage(_env.WebRootPath, "images", slider.Image);
            _db.Sliders.Remove(slider);
           await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Area("AdminPanel")]
        public async Task <IActionResult> Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider==null)
            {
                return NotFound();
            }
            return View(slider);
        }
        [HttpPost,Area("AdminPanel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Slider slider)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (slider.Photo!=null)
            {
                if (slider.Photo.IsValidImg())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa sekil secin");
                    return View();
                }
                if (slider.Photo.MaxLenght(200))
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa 200 kbtden az sekil secin ");
                    return View();
                }
                Slider dbSlider = await _db.Sliders.FindAsync(id);
                Helper.DeleteImage(_env.WebRootPath, "images", dbSlider.Image);
                dbSlider.Image= await slider.Photo.CopyImage(_env.WebRootPath, "images");
               await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
