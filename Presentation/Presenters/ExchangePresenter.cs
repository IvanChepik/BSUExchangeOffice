using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation.Presenters
{
    public class ExchangePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IExchangeView _view;
        // private readonly I _service;
        public ExchangePresenter(IKernel kernel, IExchangeView view)
        {
            _kernel = kernel;
            _view = view;

            _view.CancelAction += () => Cancel();
            _view.OkAction += () => Ok();
        }

        private void Cancel()
        {
            _kernel.Get<CashierPresenter>().Run();
            _view.Close();
        }

        private void Ok()
        {

        }

        public void Run()
        {
            _view.Show();
        }

    }
}
