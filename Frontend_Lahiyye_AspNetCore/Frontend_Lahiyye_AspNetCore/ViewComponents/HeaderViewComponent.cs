using Frontend_Lahiyye_AspNetCore.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

            return View(await Task.FromResult(model));
        }

    }
}
