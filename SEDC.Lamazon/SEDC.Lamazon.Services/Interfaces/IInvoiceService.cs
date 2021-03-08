using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IInvoiceService
    {
        int CreateInvoice(int productId, int orderId, string userId);
        IEnumerable<InvoiceViewModel> GetInvoice();

        InvoiceViewModel GetInvoiceById(int id, int orderId);

        int PayOrder(int invoiceId, int orderId, PaymentTypeViewModel payment);
    }
}
