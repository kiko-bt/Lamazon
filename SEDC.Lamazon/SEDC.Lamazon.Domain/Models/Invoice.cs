using SEDC.Lamazon.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Lamazon.Domain.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public long InvoiceNumber
        {
            get
            {
                var number = new Random();
                return number.Next(100000, 10000000);
            }
        }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public double Tax { get; set; }
        public PaymentType PaymentType { get; set; }
        public double Total { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public List<Order> Orders { get; set; }
        public List<ProductOrder> ProductOrders { get; set; }
    }

}
