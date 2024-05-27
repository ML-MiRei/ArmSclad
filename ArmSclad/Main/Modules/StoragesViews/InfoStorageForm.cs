using ArmSclad.Core.Entities;
using ArmSclad.UI.Common;

namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    public partial class InfoStorageForm : Form
    {

        private StorageEntity _storageEntity;

        public InfoStorageForm(ref StorageEntity storageEntity)
        {
            InitializeComponent();

            _storageEntity = storageEntity;

            CapacityTextBox.Text = storageEntity.Capacity.ToString();
            NameTextBox.Text = storageEntity.Name.ToString();
            AddressTextBox.Text = storageEntity.Address.ToString();
            ClosingTimePicker.Value = storageEntity.ClosingTime;
            OpeningTimePicker.Value = storageEntity.OpeningTime;
            CapacityTextBox.TextChanged += CapacityTextBox_TextChanged;
        }

        private void CapacityTextBox_TextChanged(object? sender, EventArgs e)
        {
            float num;
            if (!string.IsNullOrEmpty(CapacityTextBox.Text) && !(float.TryParse(CapacityTextBox.Text, out num)))
            {
                MessageBox.Show("Вы не можете ввести не численное значение", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CapacityTextBox.Text = CapacityTextBox.Text.Substring(0, CapacityTextBox.Text.Length - 1);
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InputValidate.CheckNotEmpty(NameTextBox, AddressTextBox, CapacityTextBox))
            {

                _storageEntity.Capacity = float.Parse(CapacityTextBox.Text.Trim());
                _storageEntity.Name = NameTextBox.Text.Trim();
                _storageEntity.Address = AddressTextBox.Text.Trim();
                _storageEntity.OpeningTime = OpeningTimePicker.Value;
                _storageEntity.ClosingTime = ClosingTimePicker.Value;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
