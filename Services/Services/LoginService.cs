using System;
using System.Collections.Generic;
using System.Linq;
using Repositories;
using DomainModel;
using Ninject;
namespace Services
{
    public class LoginService : ILoginService
    {
        private readonly IKernel _kernel;

        public LoginService (IKernel kernel)
        {
            _kernel = kernel;
        }

        public bool Login(string login, string password)         
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Cashier cashier = unitOfWork.Cashiers.FindToLogin(login, password);
            if (cashier == null)
            {
                return false;
            }
            else
            {
                _kernel.Get<Account>().Id = cashier.Id;
                return true;
            }

        }
    }
}
