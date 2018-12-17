using System;
using Ninject;
using Services;
using DomainModel;

namespace Presentation
{
    public class LoginPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ILoginView _view;
        private readonly ILoginService _service;
        public LoginPresenter (IKernel kernel, ILoginView view, ILoginService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Login += () => Login(_view.EmployeeLogin, _view.Password);
        }

        private void Login(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
            {
                _view.ShowError("Enter login");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                _view.ShowError("Enter password");
                return;
            }
            if (_kernel.Get<Account>().Login(login, password))
            {
                _kernel.Get<CashierPresenter>().Run();
                _view.Close();
            }
            else
            {
                _view.ShowError("Incorrect username/password");
            }
        }

        //public event Action Logined;

        public void Run()
        {
            _view.Show();
        }
    }
}
