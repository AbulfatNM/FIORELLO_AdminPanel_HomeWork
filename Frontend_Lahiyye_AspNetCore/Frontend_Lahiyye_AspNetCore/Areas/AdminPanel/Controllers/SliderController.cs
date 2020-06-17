using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.DAL;
using Frontend_Lahiyye_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Frontend_Lahiyye_AspNetCore.Areas.AdminPanel.Controllers
{
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        public SliderController(AppDbContext db)
        {
            _db = db;
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
    }
}
