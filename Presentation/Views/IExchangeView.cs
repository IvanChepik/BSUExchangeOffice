using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Presentation
{
    public interface IExchangeView : IView
    {
        event Action CancelAction;

        event Action OkAction;

        //void ShowMessage(string message); // мейби нахуй не надо

        Currencies ToCurrencies { get; }

        Currencies FromCurrencies { get; }

        string ToCurrenciesValue { get; }

        string FromCurrenciesValue { get; }
    }
}
