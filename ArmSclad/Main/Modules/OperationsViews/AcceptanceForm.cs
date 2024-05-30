using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.UI.Main.Modules.ProductsViews;
using MediatR;

namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    public partial class AcceptanceForm : Form
    {
        private static IMediator _mediator;
        private static IRequestService _requestService;
        private StorageEntity _selectedStorage;
        private Dictionary<ProductEntity, float> _selectedProducts = new Dictionary<ProductEntity, float>();

        public AcceptanceForm(IMediator mediator, IRequestService requestService, StorageEntity selectedStorage)
        {
            InitializeComponent();

            _mediator = mediator;
            _selectedStorage = selectedStorage;
            _requestService = requestService;

            CancelButton.Click += CloseButton_Click;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;

        }

        private void CheckBox1_CheckedChanged(object? sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedProducts.Count == 0)
            {
                MessageBox.Show("Выбраны не все элементы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_selectedStorage.FreeCapacity < _selectedProducts.Sum(p => p.Key.SpaceOccupied * p.Value))
            {
                MessageBox.Show("Невозможно погрузить товары, не хватает места", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var result = MessageBox.Show("Вы уверены, что хотите отправить заявку на погрузку?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                _requestService.SendRequestAcceptance(_selectedProducts, _selectedStorage.Id);

                bool isQualityСontrol = checkBox1.Checked;
                bool isRepackaging = checkBox2.Checked;


                if (isQualityСontrol)
                {
                    _requestService.SendRequestQualityСontrol(_selectedProducts.Keys.ToList(), _selectedStorage.Id);
                }

                if (isRepackaging)
                {
                    _requestService.SendRequestRepacking(_selectedProducts.Keys.ToList(), _selectedStorage.Id);
                }
            }
        }



        private void SelectProducts_Click(object sender, EventArgs e)
        {
            SelectProductsForm selectProductsForm = new SelectProductsForm(_mediator, ref _selectedProducts);
            selectProductsForm.ShowDialog();

            ProductsList.Items.Clear();
            foreach (var product in _selectedProducts)
            {
                ProductsList.Items.Add(new ListViewItem(new string[]
                {
                    product.Key.Id.ToString(),
                    product.Key.Name,
                    product.Value.ToString()
                }));
            }

        }
    }
}
