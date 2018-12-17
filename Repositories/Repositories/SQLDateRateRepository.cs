using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using System.Data.Entity;

namespace Repositories.Repositories
{
    public class SQLDateRateRepository : IRepository<DateRate>
    {
        private ExchangeContext db;

        public SQLDateRateRepository(ExchangeContext context)        //в аргументе функции передавать контекст
        {
            db = context;
        }

        public IEnumerable<DateRate> GetItems()
        {
            return db.DateRates;
        }

        public DateRate GetItem(int id)
        {
            return db.DateRates.Find(id);
        }

        public void Create(DateRate daterate)
        {
            db.DateRates.Add(daterate);
        }

        public void Update(DateRate dateRate)
        {
            db.Entry(dateRate).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            DateRate daterate = db.DateRates.Find(id);
            if (daterate != null)
            {
                db.DateRates.Remove(daterate);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
