using System;
using Ninject;
using Services;
using DomainModel;
using Presentation.Presenters;
namespace Presentation
{
    public class CashierPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICashierView _view;
        private readonly ILoginService _service;
        public CashierPresenter(IKernel kernel, ICashierView view, ILoginService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Exchange += () => Exchange();
        }

        private void Exchange()
        {
            _kernel.Get<ExchangePresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
