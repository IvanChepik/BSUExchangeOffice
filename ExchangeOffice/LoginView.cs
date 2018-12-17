using System;
using System.Collections.Generic;
using Presentation;
using System.Windows.Forms;

namespace ExchangeOffice
{
    public partial class LoginView : Form, ILoginView
    {
        private readonly ApplicationContext _context;

        public event Action Login;

        public LoginView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void ShowError(string message)
        {
            ErrorLabel.Text = message;
        }

        public string EmployeeLogin => LoginTextBox.Text;

        public string Password => PasswordTextBox.Text;

        private void Authorization_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            Login?.Invoke();
        }
       
        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

    }
}
