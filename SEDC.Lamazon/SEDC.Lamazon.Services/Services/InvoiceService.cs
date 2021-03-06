using AutoMapper;
using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.WebModels.Enum;
using SEDC.Lamazon.WebModels.ViewModels;
using System;
using System.Collections.Generic;

namespace SEDC.Lamazon.Services.Services
{
    public class InvoiceService : IInvoiceService
    {
        protected readonly IRepository<Invoice> _invoiceRepository;
        protected readonly IMapper _mapper;

        public InvoiceService(IRepository<Invoice> invoiceRepository,
                              IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }


        public IEnumerable<InvoiceViewModel> GetAllInvoices()
        {
            IEnumerable<Invoice> invoices = _invoiceRepository.GetAll();
            List<InvoiceViewModel> mappedInvoices = _mapper.Map<List<InvoiceViewModel>>(invoices);
            return mappedInvoices;
        }


        public InvoiceViewModel GetCurrentInvoice(int orderId)
        {
            throw new NotImplementedException();
        }

        public InvoiceViewModel GetInvoiceById(int id)
        {
            throw new NotImplementedException();
        }


        public int AddInvoice(int orderId, int productId, int invoiceId)
        {
            throw new NotImplementedException();
        }

        public int ChangeInvoice(int orderId, int productId, PaymentTypeViewModel status)
        {
            throw new NotImplementedException();
        }

        public int CreateInvoice(InvoiceViewModel invoice, string orderId)
        {
            throw new NotImplementedException();
        }
    }
}
