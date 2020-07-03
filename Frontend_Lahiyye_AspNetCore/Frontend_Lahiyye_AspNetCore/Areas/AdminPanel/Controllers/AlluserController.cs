using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.Helpers;
using Frontend_Lahiyye_AspNetCore.Models;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Frontend_Lahiyye_AspNetCore.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles ="Admin")]
    public class AlluserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AlluserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
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
                    Role = (await _userManager.GetRolesAsync(user))[0],
                    IsDelete=user.IsDelete
                    
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
            return RedirectToAction("Index");
        }
        public async Task <IActionResult> RemoveUser(string email)
        {
            AppUser userEmail = await _userManager.FindByEmailAsync(email);
            userEmail.IsDelete = true;
            await _userManager.UpdateAsync(userEmail);


            return RedirectToAction("Index");
        }

    }
    }

