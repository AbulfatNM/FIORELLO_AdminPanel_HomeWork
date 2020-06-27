using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_Lahiyye_AspNetCore.Models
{
    public class AppUser:IdentityUser
    {
        [Required,StringLength(150)]
        public string FullName { get; set; }
    }
}
