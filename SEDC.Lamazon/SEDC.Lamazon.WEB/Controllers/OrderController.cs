using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WEB.Models;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.WEB.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;


        public OrderController(IOrderService orderService,
                               IUserService userService,
                               IProductService productService)
        {
            _orderService = orderService;
            _userService = userService;
            _productService = productService;
        }


        public IActionResult ListOrders()
        {
            string userId = "3";

            List<OrderViewModel> userOrders = _orderService.GetAllOrders()
                                                           .Where(x => x.User.Id == userId)
                                                           .ToList();



            return View(userOrders);
        }


        public IActionResult ListAllOrders()
        {
            List<OrderViewModel> orders = _orderService.GetAllOrders()
                                                       .ToList();

            return View(orders);
        }


        public IActionResult OrderDetails(int orderId)
        {
            string userId = "3";
            OrderViewModel order = _orderService.GetOrderById(orderId, userId);

            if (order.Id > 0)
            {
                return View("order", order);
            }
            else
            {
                return View("Error", new ErrorViewModel());
            }
        }

        public IActionResult Order()
        {
            string userId = "3";
            OrderViewModel order = _orderService.GetCurrentOrder(userId);
            return View(order);
        }


        public IActionResult ApproveOrder(int orderId)
        {
            OrderViewModel order = _orderService.GetOrderById(orderId);
            _orderService.ChangeStatus(orderId, order.User.Id, StatusTypeViewModel.Confirmed);

            return RedirectToAction("listallorders");
        }


        public IActionResult DeclineOrder(int orderId)
        {
            OrderViewModel order = _orderService.GetOrderById(orderId);
            _orderService.ChangeStatus(orderId, order.User.Id, StatusTypeViewModel.Declined);
            return RedirectToAction("listallorders");
        }

        public int AddProduct(int productId)
        {
            string userId = "3";
            OrderViewModel order = _orderService.GetCurrentOrder(userId);

            int result = _orderService.AddProduct(productId, order.Id, userId);

            if (result >= 0)
            {
                return result;
            }
            else
            {
                string message = "Something bad happened, please contact support!";
                return result;
            }
        }
    }
}
