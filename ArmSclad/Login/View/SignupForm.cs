using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Core.Exceptions;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.Domain.UseCases.Storages.Queries.GetStorages;
using ArmSclad.UI.Main;
using MediatR;

namespace ArmSclad.UI.Modules.Login.View
{
    public partial class SignupForm : Form
    {
        private static IAuthorizationService _authorizationService;
        private static List<StorageEntity> _storageEntities;

        public SignupForm(IAuthorizationService authorizationService, IMediator mediator)
        {
            InitializeComponent();

            _authorizationService = authorizationService;
            _storageEntities = mediator.Send(new GetStoragesQuery()).Result;

            StoragesList.Items.AddRange(_storageEntities.Select(s => s.Name).ToArray());
            LoginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            var firstName = FirstNameTextBox.Text;
            var secondName = SecondNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var email = EmailTextBox.Text;
            var password = PasswordTextBox.Text;
            var phone = PhoneTextBox.Text;
            var position = PositionTextBox.Text;
            EmployeeRoleEnum role = radioButtonOperator.Checked ? EmployeeRoleEnum.Operator : EmployeeRoleEnum.Worker;
            var storage = StoragesList.SelectedIndex;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(secondName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(position)
                || string.IsNullOrEmpty(phone) || (storage == -1 && role == EmployeeRoleEnum.Worker))
            {
                MessageBox.Show("Введите все значения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var employee = _authorizationService.Registrate(new EmployeeEntity
                {
                    FirstName = firstName,
                    SecondName = secondName,
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    Phone = phone,
                    Position = position,
                    Role = role,
                    StorageId = storage,
                });

                if (role == EmployeeRoleEnum.Worker || storage != -1)
                    employee.StorageId = _storageEntities[storage].Id;

                MessageBox.Show("Регистрация прошла успешно");

                Settings.Default.Email = email;
                Settings.Default.Password = password;
                Settings.Default.Save();
                Program.CurrentUser = employee;

                Application.OpenForms.OfType<LoginForm>().SingleOrDefault().DialogResult = DialogResult.OK;
            }
            catch (EmailExistException)
            {
                MessageBox.Show("Введённый email уже зарегистрирован", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
