using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Services
{
    public abstract class Account
    {
        public bool Status { get; set; }
        public int Id { get; set; }
        public abstract bool Login(string login, string password);
    }
}
    