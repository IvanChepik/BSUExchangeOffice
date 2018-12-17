using System;
using DomainModel;
using Repositories.Repositories;

namespace Repositories
{
    public class UnitOfWork : IDisposable
    {
        private ExchangeContext db = new ExchangeContext();
        private SQLCashiersRepository cashiersRepository;
        private SQLOperationRepository operationRepository;
        private SQLRateRepository rateRepository;
        private SQLDateRateRepository dateRateRepository;
        private SQLPersonsRepository personsRepository;

        public SQLPersonsRepository Persons
        {
            get
            {
                if (personsRepository == null)
                {
                    personsRepository = new SQLPersonsRepository(db);
                }
                return personsRepository;
            }
        }

        public SQLCashiersRepository Cashiers
        {
            get
            {
                if (cashiersRepository ==null)
                {
                    cashiersRepository = new SQLCashiersRepository(db);
                }
                return cashiersRepository;
            }
        }

        public SQLDateRateRepository DateRates
        {
            get
            {
                if (dateRateRepository == null)
                {
                    dateRateRepository = new SQLDateRateRepository(db);
                }
                return dateRateRepository;
            }
        }

        public SQLRateRepository Rates
        {
            get
            {
                if (rateRepository == null)
                {
                    rateRepository = new SQLRateRepository(db);
                }
                return rateRepository;
            }
        }

        public SQLOperationRepository Operations
        {
            get
            {
                if (operationRepository == null)
                {
                    operationRepository = new SQLOperationRepository(db);
                }
                return operationRepository;
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
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
