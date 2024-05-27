using ArmSclad.Core.Entities;
using ArmSclad.UI.Common;

namespace ArmSclad.UI.Main.Modules.ProductsViews
{
    public partial class InfoProductForm : Form
    {
        private ProductEntity _productEntity;

        public InfoProductForm(ref ProductEntity productEntity)
        {
            InitializeComponent();

            _productEntity = productEntity;

            PriceTextBox.Text = productEntity.Price.ToString();
            SpaceOccupiedTextBox.Text = productEntity.SpaceOccupied.ToString();
            NumberPiecesInPackageTextBox.Text = productEntity.NumberPiecesInPackage.ToString();
            NameTextBox.Text = productEntity.Name;
            DescriptionTextBox.Text = productEntity.Description;
            


            PriceTextBox.TextChanged += PriceTextBox_TextChanged;
            SpaceOccupiedTextBox.TextChanged += SpaceOccupiedTextBox_TextChanged;
            NumberPiecesInPackageTextBox.TextChanged += NumberPiecesInPackageTextBox_TextChanged;
        }

        private void NumberPiecesInPackageTextBox_TextChanged(object? sender, EventArgs e)
        {
            InputValidate.CheckDigit(ref NumberPiecesInPackageTextBox);
        }

        private void SpaceOccupiedTextBox_TextChanged(object? sender, EventArgs e)
        {
            InputValidate.CheckDigit(ref SpaceOccupiedTextBox);
        }

        private void PriceTextBox_TextChanged(object? sender, EventArgs e)
        {
            InputValidate.CheckDigit(ref PriceTextBox);
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

            if (InputValidate.CheckNotEmpty(PriceTextBox, SpaceOccupiedTextBox, NameTextBox,
                DescriptionTextBox, NumberPiecesInPackageTextBox))
            {
                _productEntity.Price = float.Parse(PriceTextBox.Text);
                _productEntity.SpaceOccupied = float.Parse(SpaceOccupiedTextBox.Text);
                _productEntity.Name = NameTextBox.Text;
                _productEntity.Description = DescriptionTextBox.Text;
                _productEntity.NumberPiecesInPackage = float.Parse(NumberPiecesInPackageTextBox.Text);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
