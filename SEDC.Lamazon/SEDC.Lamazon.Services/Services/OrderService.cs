    using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Lamazon.Services.Services
{
    public class OrderService : IOrderService
    {
        protected readonly IRepository<Product> _productRepository;
        protected readonly IRepository<Order> _orderRepository;
        protected readonly IUserRepository _userRepository;
        protected readonly IMapper _mapper;

        public OrderService(IRepository<Product> productRepository,
                            IRepository<Order> orderRepository,
                            IUserRepository userRepository, 
                            IMapper mapper)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            IEnumerable<Order> orders = _orderRepository.GetAll();
            List<OrderViewModel> mappedOrders = _mapper.Map<List<OrderViewModel>>(orders);
            return mappedOrders;
        }

        public OrderViewModel GetCurrentOrder(string userId)
        {
            try
            {
                Order order = _orderRepository.GetAll()
                                              .Where(x => x.UserId == userId)
                                              .LastOrDefault();
                OrderViewModel mappedOrder = _mapper.Map<OrderViewModel>(order);
                return mappedOrder;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public OrderViewModel GetOrderById(int id, string userId)
        {
            try
            {
                User user = _userRepository.GetById(userId);
                Order order = _orderRepository.GetById(id);

                if (user.Id == order.UserId)
                {
                    return _mapper.Map<OrderViewModel>(order);
                }
                else
                {
                    return new OrderViewModel();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }


        public OrderViewModel GetOrderById(int id)
        {
            try
            {
                return _mapper.Map<OrderViewModel>(_orderRepository.GetById(id));
            }
            catch (Exception ex)
            {
                string message = $"Order not exist! {ex.InnerException}";
                throw new Exception(message, ex);
            }
        }

        public int AddProduct(int orderId, int productId, string userId)
        {
            try
            {
                Product product = _productRepository.GetById(productId);
                Order order = _orderRepository.GetById(orderId);

                User user = _userRepository.GetById(userId);

                order.ProductOrders.Add(
                        new ProductOrder
                        {
                            Product = product,
                            Order = order
                        }
                    );
                order.User = user;
                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public int CreateOrder(OrderViewModel order, string userId)
        {
            try
            {
                User user = _userRepository.GetById(userId);
                Order mappedOrder = _mapper.Map<Order>(order);

                mappedOrder.User = user;

                return _orderRepository.Insert(mappedOrder);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public int ChangeStatus(int orderId, string userId, StatusTypeViewModel status)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                User user = _userRepository.GetById(userId);

                order.Status = (StatusType)status;

                if (status == StatusTypeViewModel.Pending)
                {
                    _orderRepository.Insert(
                            new Order
                            {
                                User = user,
                                DateOfOrder = DateTime.Now,
                                Status = StatusType.Init,
                            }
                        );
                }
                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }
    }
}