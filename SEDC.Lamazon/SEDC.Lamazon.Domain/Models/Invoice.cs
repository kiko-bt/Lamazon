using SEDC.Lamazon.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Domain.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public long InvoiceNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public double Tax { get; set; }
        public PaymentType PaymentType { get; set; }
        public double Total { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
    }
}
