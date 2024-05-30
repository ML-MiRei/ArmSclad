using ArmSclad.UI.Common;

namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    public partial class InputAmount : Form
    {
        private float _amount;
        public float Amount => _amount;

        public InputAmount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                _amount = float.Parse(textBox1.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Введите значение");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InputValidate.CheckDigit(ref textBox1);
        }
    }
}
