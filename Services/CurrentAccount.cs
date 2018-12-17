using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Services
{
    public class CurrentAccount : Account
    {
        private readonly IKernel _kernel;
        public CurrentAccount (IKernel kernel)
        {
            _kernel = kernel;
        }
       
        public new  int Id { get; set; }
        public new bool Status { get; set; }
        public override bool Login(string login, string password)
        {
            if(_kernel.Get<ILoginService>().Login(login, password))
            {
                Status = true;
                return true;
            }
            else
            {
                Status = false;
                return false;
            }
            
        }
    }
}
