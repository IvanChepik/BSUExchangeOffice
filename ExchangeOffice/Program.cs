using System;
using System.Windows.Forms;
using Repositories;
using System.Data.Entity;
using DomainModel;
using Ninject;
using Presentation;
using Services;
using Presentation.Presenters;

namespace ExchangeOffice
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            UnitOfWork unitOfWork = new UnitOfWork();
            DateRate dateRate = new DateRate { Date = DateTime.Today };
            unitOfWork.DateRates.Create(dateRate);
            unitOfWork.Save();
            //Cashier cashier = new Cashier {Login = "Иван", Password = "987654321123456789" };
            //Operation operation = new Operation { Id = 2, DateOfOperation = DateTime.Now, FromCurrency = "USD", ToCurrency = "BYN", CashierId = cashier.Id };
            //unitOfWork.Cashiers.Create(cashier);
            //unitOfWork.Operations.Create(operation);
            //unitOfWork.Save();
            //using (ExchangeContext db = new ExchangeContext())
            //{
            //    Cashier cashier = new Cashier { Id = 2, Login = "Armak1", Password = "123" };
            //    Operation operation = new Operation { Id = 2, DateOfOperation = DateTime.Now, FromCurrency = "USD", ToCurrency = "BYN", CashierId = 1 };
            //    db.Cashiers.Add(cashier);
            //    db.Operations.Add(operation);
            //    Cashier cashier1 = new Cashier { Id = 3, Login = "Armak2", Password = "123" };
            //    Operation operation1 = new Operation { Id = 3, DateOfOperation = DateTime.Now, FromCurrency = "USD", ToCurrency = "BYN", CashierId = 2 };
            //    db.Cashiers.Add(cashier1);
            //    db.Operations.Add(operation1);
            //    Cashier cashier2 = new Cashier { Id = 4, Login = "Armak3", Password = "123" };
            //    Operation operation2 = new Operation { Id = 4, DateOfOperation = DateTime.Now, FromCurrency = "USD", ToCurrency = "BYN", CashierId = 2 };
            //    db.Cashiers.Add(cashier2);
            //    db.Operations.Add(operation2);
            //    db.SaveChanges();
            //}
            
            StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ILoginView>().To<LoginView>();
            kernel.Bind<IExchangeView>().To<ExchangeView>();
            kernel.Bind<ICashierView>().To<CashierView>();
            kernel.Bind<ILoginService>().To<LoginService>().InSingletonScope();
            kernel.Bind<Account>().To<CurrentAccount>().InSingletonScope();
            kernel.Bind<LoginPresenter>().ToSelf();
            kernel.Bind<CashierPresenter>().ToSelf();
            kernel.Bind<ExchangePresenter>().ToSelf();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<LoginPresenter>().Run();

            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
