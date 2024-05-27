using ArmSclad.UI.Common;
using ArmSclad.UI.Main.Modules.ClientsViews;
using ArmSclad.UI.Main.Modules.ProductsViews;
using ArmSclad.UI.Main.Modules.StoragesViews;
using System.ComponentModel;
using System.Windows.Input;

namespace ArmSclad.UI.Main
{
    public partial class MainForm : Form
    {
        private static Form _activeForm;

        public MainForm(StoragesForm storagesForm, ProductsForm productsForm, ClientsForm clientsForm)
        {
            InitializeComponent();

            PageContent.Controls.Add(storagesForm);
           
            ToProductsPageButton.Command = new NavigateCommand(this);
            ToProductsPageButton.CommandParameter = productsForm;
            ToStoragePageButton.Command = new NavigateCommand(this);
            ToStoragePageButton.CommandParameter = storagesForm;
            ToClientsPageButton.Command = new NavigateCommand(this);
            ToClientsPageButton.CommandParameter = clientsForm;

            _activeForm = storagesForm;
            storagesForm.Show();

        }

        protected override void OnActivated(EventArgs e)
        {
            UserName.Text = Program.CurrentUser.FullName;
            base.OnActivated(e);
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
                Close();
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
