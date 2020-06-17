using Frontend_Lahiyye_AspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public Content Content { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        //public IEnumerable<Product> Products { get; set; }
    }
}
