using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.Helpers;
using Frontend_Lahiyye_AspNetCore.Models;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Frontend_Lahiyye_AspNetCore.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AlluserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _rolMeneger;

        public AlluserController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _rolMeneger = roleManager;
        }
     
        public async Task <IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();
            

            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM
                {
                    FullName = user.FullName,
                    UserName = user.UserName,
                    Email = user.Email,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };
                usersVM.Add(userVM);
            }
            return View(usersVM);
        }
    [Area("AdminPanel")]

        public IActionResult ChangeRols()
        {
        
            return View();
        }
        [HttpPost]
        [Area("AdminPanel")]
        public async Task<IActionResult> ChangeRols(string email, string rolname)
        {
            //await _userManager.AddToRoleAsync(, Helper.UserRols.Member.ToString());
            
            AppUser user = await _userManager.FindByEmailAsync(email);
            string oldRole = (await _userManager.GetRolesAsync(user))[0];

            if (rolname!=oldRole)
            {
                await _userManager.RemoveFromRoleAsync(user, oldRole);
                await _userManager.AddToRoleAsync(user, rolname);
            }
            //var userRol = await _rolMeneger.FindByNameAsync(rolname);
        
           
        
            return RedirectToAction("Index");


        }


    }
    }

