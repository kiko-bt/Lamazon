using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IInvoiceService
    {
        IEnumerable<InvoiceViewModel> GetAllInvoices();
        InvoiceViewModel GetInvoiceById(int id);
        int CreateInvoice(InvoiceViewModel invoice, string orderId);
        int AddInvoice(int orderId, int productId, int invoiceId);
        InvoiceViewModel GetCurrentInvoice(int orderId);
        int ChangeInvoice(int orderId, int productId, PaymentTypeViewModel status);
    }
}
