using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DomainModel;


namespace Repositories
{
    public class SQLCashiersRepository : IRepository<Cashier>
    {
        private ExchangeContext db;     //в аргументе функции передавать контекст

        public SQLCashiersRepository(ExchangeContext context)
        {
            db = context;
        }

        public IEnumerable<Cashier> GetItems()
        {
            return db.Cashiers;
        }

        public Cashier GetItem(int id)
        {
            return db.Cashiers.Find(id);
        }

        public Cashier FindToLogin(string login, string password)
        {
            Cashier cashier = db.Cashiers.FirstOrDefault(p => p.Login == login);
            return cashier;
        }

        public void Create(Cashier cashier)
        {
            db.Cashiers.Add(cashier);
        }

        public void Update(Cashier cashier)
        {
            db.Entry(cashier).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Cashier cashier = db.Cashiers.Find(id);
            if (cashier != null)
            {
                db.Cashiers.Remove(cashier);
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
