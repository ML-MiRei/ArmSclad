using ArmSclad.UI.Common;
using ArmSclad.UI.Main.Modules.ClientsViews;
using ArmSclad.UI.Main.Modules.OperationsViews;
using ArmSclad.UI.Main.Modules.OperationsWithProductsViews;
using ArmSclad.UI.Main.Modules.OrdersView;
using ArmSclad.UI.Main.Modules.ProductsViews;
using ArmSclad.UI.Main.Modules.StoragesViews;
using System.ComponentModel;
using System.Windows.Input;

namespace ArmSclad.UI.Main
{
    public partial class MainForm : Form
    {
        private static Form _activeForm;
        private static StoragesForm _storagesForm;
        private static ProductsForm _productsForm;
        private static ClientsForm _clientsForm;
        private static ObserveOperationsForm _observeOperationsForm;
        private static OperationsWithProductsForm _operationsWithProductsForm;
        private static OrdersForm _ordersForm;
        private static OperationsEmployeeForm _operationsEmployeeForm;
        private static LoginForm _loginForm;


        public MainForm(StoragesForm storagesForm, ProductsForm productsForm,
            ClientsForm clientsForm, ObserveOperationsForm observeOperationsForm,
            OperationsWithProductsForm operationsWithProductsForm, OrdersForm ordersForm,
            OperationsEmployeeForm operationsEmployeeForm, LoginForm loginForm)
        {
            InitializeComponent();

            _storagesForm = storagesForm;
            _operationsWithProductsForm = operationsWithProductsForm;
            _ordersForm = ordersForm;
            _clientsForm = clientsForm;
            _observeOperationsForm = observeOperationsForm;
            _productsForm = productsForm;
            _operationsEmployeeForm = operationsEmployeeForm;
            _loginForm = loginForm;
        }

        protected override void OnShown(EventArgs e)
        {
            UserName.Text = Program.CurrentUser.FullName;

            if (Program.CurrentUser.Role == Core.Enums.EmployeeRoleEnum.Operator)
            {
                PageContent.Controls.Add(_storagesForm);

                ToProductsPageButton.Command = new NavigateCommand(this);
                ToProductsPageButton.CommandParameter = _productsForm;

                ToStoragePageButton.Command = new NavigateCommand(this);
                ToStoragePageButton.CommandParameter = _storagesForm;

                ToClientsPageButton.Command = new NavigateCommand(this);
                ToClientsPageButton.CommandParameter = _clientsForm;

                ToOperationsPageButton.Command = new NavigateCommand(this);
                ToOperationsPageButton.CommandParameter = _observeOperationsForm;

                ToOperationsWithProductsPageButton.Command = new NavigateCommand(this);
                ToOperationsWithProductsPageButton.CommandParameter = _operationsWithProductsForm;

                ToOrdersPageButton.Command = new NavigateCommand(this);
                ToOrdersPageButton.CommandParameter = _ordersForm;

                _activeForm = _storagesForm;
                _activeForm.Show();
            }
            else
            {
                ToProductsPageButton.Visible = false;
                ToStoragePageButton.Visible = false;
                ToClientsPageButton.Visible = false;
                ToOperationsWithProductsPageButton.Visible = false;
                ToOrdersPageButton.Visible = false;
                ToOperationsPageButton.Visible = false;

                PageContent.Controls.Add(_operationsEmployeeForm);
                _operationsEmployeeForm.Show();
            }

            base.OnShown(e);
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            TaskManager.WaitAllTask();
            base.OnClosing(e);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Выход", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }



        private void Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Settings.Default.Email = "";
                Settings.Default.Password = "";
                Settings.Default.Save();

                Visible = false;
                var res = _loginForm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    Application.Restart();
                }
                else
                {
                    Close();
                }
            }

        }


        private class NavigateCommand(MainForm mainForm) : ICommand
        {
            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                if (!Equals(_activeForm, parameter))
                {
                    mainForm.PageContent.Controls.Clear();
                    mainForm.PageContent.Controls.Add((Form)parameter);
                    ((Form)parameter).Show();
                    _activeForm = (Form)parameter;
                }

            }
        }
    }
}
