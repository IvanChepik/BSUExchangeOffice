using System;
using System.Windows.Forms;
using Presentation;

namespace ExchangeOffice
{
    public partial class CashierView : Form, ICashierView
    {
        private readonly ApplicationContext _context;

        public CashierView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public event Action Exchange;

        private void ExchangeButton_Click(object sender, EventArgs e)
        {
            Exchange?.Invoke();
        }
    }
}
