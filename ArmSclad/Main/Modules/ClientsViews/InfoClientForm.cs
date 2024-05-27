using ArmSclad.Core.Entities;
using ArmSclad.UI.Common;

namespace ArmSclad.UI.Main.Modules.ClientsViews
{
    public partial class InfoClientForm : Form
    {
        private ClientEntity _clientEntity;

        public InfoClientForm(ref ClientEntity clientEntity)
        {
            InitializeComponent();

            _clientEntity = clientEntity;

            CancelButton.Click += CloseButton_Click;
            FirstNameTextBox.Text = clientEntity.FirstName;
            SecondNameTextBox.Text = clientEntity.SecondName;
            LasstNameTextBox.Text = clientEntity.LastName;
            PhoneNumberTextBox.Text = clientEntity.Phone;
            AddressTextBox.Text = clientEntity.Address;
            EmailTextBox.Text = clientEntity.Email;

            if (clientEntity.Status == Core.Enums.ClientStatusEnum.PhysicalPerson)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (InputValidate.CheckNotEmpty(FirstNameTextBox, SecondNameTextBox, PhoneNumberTextBox,
                LasstNameTextBox, EmailTextBox, AddressTextBox))
            {
                _clientEntity.FirstName = FirstNameTextBox.Text;
                _clientEntity.SecondName = SecondNameTextBox.Text;
                _clientEntity.Email = EmailTextBox.Text;
                _clientEntity.LastName = LasstNameTextBox.Text;
                _clientEntity.Address = AddressTextBox.Text;
                _clientEntity.Phone = PhoneNumberTextBox.Text;
                _clientEntity.Status = radioButton1.Checked ? Core.Enums.ClientStatusEnum.PhysicalPerson : Core.Enums.ClientStatusEnum.Organization;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
