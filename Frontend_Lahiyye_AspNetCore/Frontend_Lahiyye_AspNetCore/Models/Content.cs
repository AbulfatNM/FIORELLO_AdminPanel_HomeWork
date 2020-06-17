using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.Models
{
    public class Content
    {
        public int Id { get; set; }
        [Required,StringLength(155)]
        public string Title { get; set; }
        [Required,MinLength(150),MaxLength(400)]
        public string Description { get; set; }
        [Required,StringLength(255)]
        public string Image { get; set; }
    }
}
