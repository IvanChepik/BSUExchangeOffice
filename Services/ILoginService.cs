using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Services
{
    public interface ILoginService
    {
        bool Login(string login, string password);
    }
}
