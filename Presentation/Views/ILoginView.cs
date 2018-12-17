using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ILoginView : IView
    {
        event Action Login;

        void ShowError(string message);

        string EmployeeLogin { get; }

        string Password { get; }
    }
}
