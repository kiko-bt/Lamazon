using SEDC.Lamazon.DataAccess.Interfaces;
using SEDC.Lamazon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Lamazon.DataAccess.Repositories
{
    public class InvoiceRepository : BaseRepository, IRepository<Invoice>
    {
        public InvoiceRepository(LamazonDbContext context) : base(context) { }


        public IEnumerable<Invoice> GetAll()
        {
            return _db.Invoices;
        }

        public Invoice GetById(int id)
        {
            return _db.Invoices.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Invoice entity)
        {
            _db.Invoices.Add(entity);
            return _db.SaveChanges();
        }

        public int Update(Invoice entity)
        {
            _db.Invoices.Update(entity);
            return _db.SaveChanges();
        }

        public int Delete(int id)
        {
            Invoice invoice = _db.Invoices.SingleOrDefault(x => x.Id == id);

            if (invoice == null)
                return -1;
            _db.Invoices.Remove(invoice);
            return _db.SaveChanges();
        }
    }
}
