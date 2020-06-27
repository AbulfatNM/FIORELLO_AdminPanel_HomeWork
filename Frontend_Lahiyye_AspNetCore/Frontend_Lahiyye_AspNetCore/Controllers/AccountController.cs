using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.Models;
using Frontend_Lahiyye_AspNetCore.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace Frontend_Lahiyye_AspNetCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Register(RegisterVM register)
        {
            
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            AppUser newUser = new AppUser()
            {
                FullName = register.FullName,
                UserName = register.UserName,
                Email = register.Email,

            };
            IdentityResult identityResult =await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
           await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }
    }
}
