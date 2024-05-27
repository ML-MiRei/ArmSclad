using ArmSclad.Domain.Interfaces.Services.AuthorizationService;
using ArmSclad.Core.Exceptions;
using ArmSclad.UI.Main;

namespace ArmSclad.UI.Modules.Login.View
{
    public partial class SigninForm : Form
    {
        private static IAuthorizationService _authorizationService;
        private static MainForm _mainForm;

        public SigninForm(IAuthorizationService authorizationService, MainForm mainForm)
        {
            InitializeComponent();

            _authorizationService = authorizationService;
            _mainForm = mainForm;

            LoginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            var email = EmailTextBox.Text;
            var password = PasswordTextBox.Text;

            if (email == null || password == null)
            {
                MessageBox.Show("Введите все значения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var employee = _authorizationService.Authorize(email, password);
                Settings.Default.Email = email;
                Settings.Default.Password = password;
                Settings.Default.Save();
                Program.CurrentUser = employee;

                MessageBox.Show("Авторизация прошла успешно");

                Application.OpenForms.OfType<LoginForm>().SingleOrDefault().Close();
                _mainForm.Show();
            }
            catch (EmailNotExistException)
            {
                MessageBox.Show("Введённый email не найден", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AuthorizeException)
            {
                MessageBox.Show("Неправильно введён пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
