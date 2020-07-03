using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Frontend_Lahiyye_AspNetCore.Helpers;
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
        private readonly RoleManager<IdentityRole> _rolMeneger;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolMeneger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _rolMeneger = rolMeneger;
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
            await _userManager.AddToRoleAsync(newUser,Helper.UserRols.Member.ToString());
           await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }
        public async Task <IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
               
                return View(login);
            }
            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);
            if (loginUser==null)
            {
                ModelState.AddModelError("", "Email və ya parolunuz səfdir");
                return View(login);
            }
            var sigInResult = await _signInManager.PasswordSignInAsync(loginUser, login.Password, false, true);
            if (!sigInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email və ya parolunuz səfdir");
                return View(login);
            }
            if (loginUser.IsDelete == true)
            {
                ModelState.AddModelError("", "Sizin hesabiniz silinmişdir !!");
                return View();
            }
            return RedirectToAction(nameof(HomeController.Index), "Home");

        }
        public async Task CreateRol()
        {
            if (!await _rolMeneger.RoleExistsAsync(Helper.UserRols.Admin.ToString()))
            {
               await _rolMeneger.CreateAsync(new IdentityRole(Helper.UserRols.Admin.ToString()));
            }
            if (!await _rolMeneger.RoleExistsAsync(Helper.UserRols.Member.ToString()))
            {
                await _rolMeneger.CreateAsync(new IdentityRole(Helper.UserRols.Member.ToString()));
            }
   
        }
    }
}
