using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name bos buraxmayin !!"),MinLength(3,ErrorMessage = "En azi 3 simvol daxil edin !!"),MaxLength(150,ErrorMessage = "En coxu 150 simvol daxil edin !!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Descriptionu bos buraxmayin !!"),MaxLength(350,ErrorMessage ="En coxu 350 simvol daxil edin !! ")]
        public string Description { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
    }
}
