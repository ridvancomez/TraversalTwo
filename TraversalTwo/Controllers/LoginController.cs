using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalTwo.Models;

namespace TraversalTwo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {
            AppUser user = new AppUser()
            {
                Name = p.Name,
                Surname = p.SurName,
                UserName = p.UserName,
                Email = p.Mail,
                Gender = p.Gender,
                ImageUrl = ""
            };

            if(p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(user, p.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Passwords do not match.");
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SignIn()
        //{
        //    return View();
        //}
    }
}
