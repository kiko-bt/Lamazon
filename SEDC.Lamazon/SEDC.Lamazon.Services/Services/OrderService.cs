using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Enum;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Lamazon.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IUserRepository _userRepository;

        public OrderService(IRepository<Product> productRepository, 
                            IRepository<Order> orderRepository,
                            IUserRepository userRepository)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }


        //TODO: Refactor the code when ViewModels will be implemented
        public IEnumerable<OrderViewModel> GetAllOrders()
        {
            //IEnumerable<Order> orders = _orderRepository.GetAll();
            //return orders;
            throw new NotImplementedException();
        }


        public OrderViewModel GetCurrentOrder(int userId)
        {
            try
            {
                //Order order = _orderRepository.GetAll()
                //                              .Where(x => x.UserId == userId)
                //                              .LastOrDefault();

                //return order;

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new NotImplementedException();
            }
        }


        public OrderViewModel GetOrderById(int id)
        {
            try
            {
                //return _orderRepository.GetById(id);
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new NotImplementedException(message);
            }
        }


        public int AddProduct(int productId, int orderId, int userId)
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
                                    });

                order.User = user;
                return _orderRepository.Update(order);
            }
            catch (Exception ex) { string message = ex.Message; throw new NotImplementedException(message); }
            
        }


        public int CreateOrder(OrderViewModel order, int userId)
        {
            try
            {
                //User user = _userRepository.GetById(userId);

                //order.User = user;

                //return _orderRepository.Insert(order);

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new NotImplementedException(message);
            }
        }

        public int ChangeStatus(int orderId, int userId, StatusType status)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                User user = _userRepository.GetById(userId);

                order.Status = status;

                if (status == StatusType.Pending)
                {
                    _orderRepository.Insert(
                                    new Order
                                    {
                                        User = user,
                                        DateOfOrder = DateTime.Now,
                                        Status = StatusType.Init
                                    });
                }

                return _orderRepository.Update(order);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new NotImplementedException(message);
            }
        }

        IEnumerable<Order> IOrderService.GetAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}
