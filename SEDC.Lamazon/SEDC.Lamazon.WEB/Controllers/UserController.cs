using System;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;

namespace SEDC.Lamazon.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;

        public UserController(IUserService userService,
                              IToastNotification toastNotification)
        {
            _userService = userService;
            _toastNotification = toastNotification;
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
                    bool isAdmin;
                    Log.Debug($"Authenticating user with username: {model.Username}");
                    _userService.Login(model, out isAdmin);
                    if (isAdmin)
                    {
                        _toastNotification.AddSuccessToastMessage($"Welcome {model.Username}. You are logged in as an admin");

                        Log.Debug($"User with username {model.Username} successfully logged in! Admin user");
                        return RedirectToAction("listallorders", "order");
                    }
                    else
                    {
                        _toastNotification.AddSuccessToastMessage($"Welcome {model.Username}. You are logged in as a customer");

                        Log.Debug($"User with username {model.Username} successfully logged in! Customer user");
                        return RedirectToAction("products", "product");
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message}");
            }
            return View(model);
        }

        public IActionResult Register()
        {
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userService.Register(model);
                    _toastNotification.AddSuccessToastMessage($"You have successfully registered your account");
                    Log.Debug($"{model.Username} have successfully registered");
                    return RedirectToAction("products", "product");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }
    }
}