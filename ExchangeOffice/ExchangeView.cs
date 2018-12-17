using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DomainModel;
using System.Windows.Forms;
using Presentation;

namespace ExchangeOffice
{
    public partial class ExchangeView : Form, IExchangeView
    {
        private readonly ApplicationContext _context;

        public ExchangeView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            FromComboBox.DataSource = Enum.GetValues(typeof(Currencies));
            ToComboBox.DataSource = Enum.GetValues(typeof(Currencies));
        }

        public Currencies ToCurrencies => (Currencies)ToComboBox.SelectedItem;

        public Currencies FromCurrencies => (Currencies)FromComboBox.SelectedItem;

        public event Action CancelAction;

        public event Action OkAction;

        public string ToCurrenciesValue => ToValueTextBox.Text;

        public string FromCurrenciesValue => FromValueTextBox.Text;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void Ok_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            CancelAction?.Invoke();
        }
    }
}
