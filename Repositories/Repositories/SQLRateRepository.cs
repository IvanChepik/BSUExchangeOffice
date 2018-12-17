using System;
using System.Collections.Generic;
using System.Data.Entity;
using DomainModel;

namespace Repositories.Repositories
{
    public class SQLRateRepository : IRepository<ExchangeRate>
    {
        private ExchangeContext db;

        public SQLRateRepository(ExchangeContext context)        //в аргументе функции передавать контекст
        {
            db = context;
        }

        public IEnumerable<ExchangeRate> GetItems()
        {
            return db.Rates;
        }

        public ExchangeRate GetItem(int id)
        {
            return db.Rates.Find(id);
        }

        public void Create(ExchangeRate rate)
        {
            db.Rates.Add(rate);
        }

        public void Update(ExchangeRate rate)
        {
            db.Entry(rate).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            ExchangeRate rate = db.Rates.Find(id);
            if (rate != null)
            {
                db.Rates.Remove(rate);
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
