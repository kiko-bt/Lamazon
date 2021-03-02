using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;

namespace SEDC.Lamazon.WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }


        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(model);

                return RedirectToAction("products", "product");
            }


            return View(model);
        }



        public IActionResult LogIn()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }


        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userService.LogIn(model);
                    if (User.IsInRole("Admin"))
                    {
                        return RedirectToAction("listallorders", "order");
                    }
                    else
                    {
                        return RedirectToAction("products", "product");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return View(model);
        }


        public IActionResult Logout()
        {
            _userService.LogOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
