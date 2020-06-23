using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;


namespace Frontend_Lahiyye_AspNetCore.Areas.AdminPanel.Controllers
{
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
            if (!slider.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo","Zehmet olmasa sekil secin");
                return View();
            }
            if (slider.Photo.Length/1020>=200)
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa 200 kbtden az sekil secin ");
                return View();
            }
            string path =Path.Combine(_env.WebRootPath, "images");
            string resultPath=Path.Combine(path, Guid.NewGuid() + slider.Photo.FileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await slider.Photo.CopyToAsync(fileStream);
            }
            return Content("Success");

        }
    }
}
