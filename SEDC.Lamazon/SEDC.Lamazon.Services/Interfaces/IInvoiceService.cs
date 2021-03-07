using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Services.Interfaces
{
    public interface IInvoiceService
    {
        int CreateInvoice(InvoiceViewModel invoice, int orderId, int productId);
        IEnumerable<InvoiceViewModel> GetInvoice();
    }
}
