using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.ViewModels;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.Lamazon.WEB.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IOrderService _orderService;

        public InvoiceController(IInvoiceService invoiceService,
                                IOrderService orderService)
        {
            _invoiceService = invoiceService;
            _orderService = orderService;
        }

        public IActionResult CurrentInvoice()
        {
            List<InvoiceViewModel> invoice = _invoiceService.GetInvoice().ToList();


            return View(invoice);
        }

        public IActionResult Payment(int invoiceId, int orderId)
        {
            try
            {
                InvoiceViewModel invoice = _invoiceService.GetInvoiceById(invoiceId, orderId);
                _invoiceService.PayOrder(invoice.Id, invoice.Order.Id, invoice.PaymentType);

                return View(invoice);
            }
            catch (Exception ex)
            {
                Log.Error($"Message: {ex.Message} | Exception: {ex.InnerException}");
            }
            return PartialView("_ErrorView");
        }
    }
}
