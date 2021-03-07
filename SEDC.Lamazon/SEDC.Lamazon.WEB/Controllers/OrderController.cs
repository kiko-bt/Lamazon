using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.Web.Models;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;

namespace SEDC.Lamazon.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;


        public OrderController(IOrderService orderService,
                               IUserService userService,
                               IProductService productService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        [Authorize(Roles = "user")]
        public IActionResult ListOrders()
        {
            try
            {
                //string userId = "3";
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                List<OrderViewModel> userOrders = _orderService.GetAllOrders()
                                                                .Where(x => x.User.Id == user.Id)
                                                                .ToList();
                return View(userOrders);
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("_ErrorView");
        }

        [Authorize(Roles = "admin")]
        public IActionResult ListAllOrders()
        {
            try
            {
                List<OrderViewModel> orders = _orderService.GetAllOrders().ToList();
                return View(orders);
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("_ErrorView");
        }

        [Authorize(Roles = "user")]
        public IActionResult OrderDetails(int orderId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderViewModel order = _orderService.GetOrderById(orderId, user.Id);

                if (order.Id > 0)
                {
                    return View("order", order);
                }
                else
                {
                    return View("Error", new ErrorViewModel());
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("ErrorView");
        }

        [Authorize(Roles = "user")]
        public IActionResult Order()
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderViewModel order = _orderService.GetCurrentOrder(user.Id);
                return View(order);
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("_ErrorView");
        }

        [Authorize(Roles = "admin")]
        public IActionResult ApproveOrder(int orderId, int invoiceId)
        {
            try
            {
                OrderViewModel order = _orderService.GetOrderById(orderId);


                _orderService.ChangeStatus(order.Id, order.User.Id, StatusTypeViewModel.Confirmed);
                return RedirectToAction("listallorders");
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("_ErrorView");
        }

        [Authorize(Roles = "admin")]
        public IActionResult DeclineOrder(int orderId)
        {
            try
            {
                OrderViewModel order = _orderService.GetOrderById(orderId);
                _orderService.ChangeStatus(order.Id, order.User.Id, StatusTypeViewModel.Declined);
                return RedirectToAction("listallorders");
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("_ErrorView");
        }

        [Authorize(Roles = "user")]
        public IActionResult ChangeStatus(int statusId, int orderId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                _orderService.ChangeStatus(orderId, user.Id, (StatusTypeViewModel)statusId);
                return RedirectToAction("ListOrders");
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("_ErrorView");
        }

        [Authorize(Roles = "user")]
        public int AddProduct(int productId)
        {
            try
            {
                UserViewModel user = _userService.GetCurrentUser(User.Identity.Name);
                OrderViewModel order = _orderService.GetCurrentOrder(user.Id);

                int result = _orderService.AddProduct(order.Id, productId, user.Id);

                if (result >= 0)
                {
                    Log.Debug($"Product was added successfully. Result: {result}");
                    return result;
                }
                else
                {
                    Log.Debug($"Product was not added successfully. Result: {result}");
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return -1;
        }
    }
}