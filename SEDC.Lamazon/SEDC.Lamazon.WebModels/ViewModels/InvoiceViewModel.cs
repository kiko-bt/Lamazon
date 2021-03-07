using SEDC.Lamazon.WebModels.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.WebModels.ViewModels
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }
        public long InvoiceNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public double Tax { get; set; }
        public PaymentTypeViewModel PaymentType { get; set; }
        public double Total { get; set; }
        public OrderViewModel Order { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
