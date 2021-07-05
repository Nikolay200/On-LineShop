using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.BDModels;
using OnlineShopWebApp.Controllers;
using OnlineShopWebApp.Models;
using System;
using Register = OnlineShopWebApp.Models.Register;

namespace OnlineShopWebApp.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountController : Controller
    {   
        
        private readonly UserManager<User> userManager;//Пользователь, который ещё не авторизовался
        private readonly SignInManager<User> signInManager; //Пользователь, который уже авторизовался

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {           
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new Login() {ReturnUrl = returnUrl});
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            
            if(ModelState.IsValid)
            {
                var result = signInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false).Result;
                if(result.Succeeded)
                 {
                     return Redirect(login.ReturnUrl ?? "/Home");
                 }
                else
                {
                    ModelState.AddModelError("", "Неправильный пароль");
                }
                return View(login);
            }
            var userAccount = userManager.FindByNameAsync(login.UserName);
            if (userAccount == null)
            {
                ModelState.AddModelError("", "Такого пользователя не существует");
            }

            if (userAccount.Equals(login.Password))
            {
                ModelState.AddModelError("", "Пароль неправильный");
                return RedirectToAction(nameof(Login));
            }

            return View(login);                       
        }

        public IActionResult Register(string returnUrl)
        {
            return View(new Register() {ReturnUrl = returnUrl});
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            if (register.UserName == register.Password)
            {
                ModelState.AddModelError("", "Имя и пароль не должны совпадать");
            }
            if (ModelState.IsValid)
            {

                User user = new User { Email = register.UserName, UserName = register.UserName, PhoneNumber = register.Phone };
                var result = userManager.CreateAsync(user, register.Password).Result;
                if (result.Succeeded)
                {
                    //добавление Cookies
                    signInManager.SignInAsync(user, false).Wait();
                    TryAssignUserRole(user);
                    return Redirect(register.ReturnUrl ?? "/Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }               
            }
            return View(register);
        }

        private void TryAssignUserRole(User user)
        {
            try
            {
                userManager.AddToRoleAsync(user, Constants.UserRoleName).Wait();
            }
            catch (Exception)
            {

                throw;//Сделать логирование данных
            }
        }
    }
}
