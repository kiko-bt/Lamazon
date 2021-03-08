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
using System.Text;

namespace SEDC.Lamazon.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        protected readonly IRepository<Invoice> _invoiceRepository;
        protected readonly IRepository<Product> _productRepository;
        protected readonly IRepository<Order> _orderRepository;
        protected readonly IUserRepository _userRepository;
        protected readonly IMapper _mapper;


        public InvoiceService(IRepository<Invoice> invoiceRepository,
                    IRepository<Order> orderRepository,
                    IUserRepository userRepository,
                    IRepository<Product> productRepository,
                    IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public int CreateInvoice(int productId, int orderId, string userId)
        {
            Product product = _productRepository.GetById(productId);
            Order order = _orderRepository.GetById(orderId);
            User user =_userRepository.GetById(userId);

            return _invoiceRepository.Insert(
                              new Invoice
                              {
                                  OrderId = order.Id,
                                  From = "Lamazon",
                                  To = user.FullName,
                                  Tax = 0.8,
                                  Date = order.DateOfOrder.ToLocalTime(),
                                  Order = order,
                                  ProductOrders = order.ProductOrders,
                                  Total = product.Price * 0.8
                              });
        }

        public IEnumerable<InvoiceViewModel> GetInvoice()
        {
            IEnumerable<Invoice> invoices = _invoiceRepository.GetAll();
            List<InvoiceViewModel> mappedInvoices = _mapper.Map<List<InvoiceViewModel>>(invoices);

            


            return mappedInvoices;
        }

        public InvoiceViewModel GetInvoiceById(int id, int orderId)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                Invoice invoice = _invoiceRepository.GetById(id);

                if (order.Id == invoice.Id)
                {
                    return _mapper.Map<InvoiceViewModel>(invoice);
                }
                else
                {
                    return new InvoiceViewModel();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }

        public InvoiceViewModel GetInvoiceById(int id, int orderId, PaymentTypeViewModel model)
        {
            throw new NotImplementedException();
        }

        public int PayOrder(int invoiceId, int orderId, PaymentTypeViewModel payment)
        {
            try
            {
                Order order = _orderRepository.GetById(orderId);
                Invoice invoice = _invoiceRepository.GetById(invoiceId);

                invoice.PaymentType = (PaymentType)payment;

                if (payment == PaymentTypeViewModel.Cash)
                {
                    _invoiceRepository.Insert(
                            new Invoice
                            {
                                Date = DateTime.Now,
                                PaymentType = PaymentType.Cash,
                                Total = invoice.Total,
                                OrderId = order.Id
                            }
                        ); 
                }
                return _invoiceRepository.Insert(invoice);

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message);
            }
        }
    }
}
