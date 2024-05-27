namespace ArmSclad.UI.Common
{
    public class InputValidate
    {
        public static void CheckDigit(ref TextBox textBox)
        {
            float num;
            if (textBox.Text != "" && !float.TryParse(textBox.Text, out num))
            {
                MessageBox.Show("Вы не можете ввести не численное значение", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }

        public static bool CheckNotEmpty(params TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if(string.IsNullOrEmpty(textBox.Text.Trim()))
                {
                    MessageBox.Show("Введите все значения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

    }
}
