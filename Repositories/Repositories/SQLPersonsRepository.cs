using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel;
using System.Threading.Tasks;
using DomainModel.Models;
using System.Data.Entity;

namespace Repositories.Repositories
{
    public class SQLPersonsRepository : IRepository<Person>
    {
        private ExchangeContext db;     //в аргументе функции передавать контекст

        public SQLPersonsRepository(ExchangeContext context)
        {
            db = context;
        }

        public IEnumerable<Person> GetItems()
        {
            return db.Persons;
        }

        public Person GetItem(int id)
        {
            return db.Persons.Find(id);
        }

        public void Create(Person person)
        {
            db.Persons.Add(person);
        }

        public void Update(Person person)
        {
            db.Entry(person).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Person person = db.Persons.Find(id);
            if (person != null)
            {
                db.Persons.Remove(person);
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
