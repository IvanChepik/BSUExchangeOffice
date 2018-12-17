using System;
using System.Collections.Generic;
using System.Data.Entity;
using DomainModel;

namespace Repositories
{
    public class SQLOperationRepository : IRepository<Operation>
    {
        private ExchangeContext db;

        public SQLOperationRepository(ExchangeContext context)        //в аргументе функции передавать контекст
        {
            db = context;
        }

        public IEnumerable<Operation> GetItems()
        {
            return db.Operations;
        }

        public Operation GetItem(int id)
        {
            return db.Operations.Find(id);
        }

        public void Create(Operation operation)
        {
            db.Operations.Add(operation);
        }

        public void Update(Operation operation)
        {
            db.Entry(operation).State = EntityState.Modified;
        }

        public void Delete (int id)
        {
            Operation operation = db.Operations.Find(id);
            if(operation!=null)
            {
                db.Operations.Remove(operation);
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
