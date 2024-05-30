using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.UI.Main.Modules.ProductsViews;
using ArmSclad.UI.Main.Modules.StoragesViews;
using MediatR;

namespace ArmSclad.UI.Main.Modules.OperationsViews
{
    public partial class MoovingForm : Form
    {
        private static IMediator _mediator;
        private static IRequestService _requestService;
        private int _oldStorageId;
        private Dictionary<ProductEntity, float> _selectedProducts = new Dictionary<ProductEntity, float>();
        private StorageEntity _selectedNewStorage;



        public MoovingForm(IMediator mediator, IRequestService requestService, int storageId)
        {
            InitializeComponent();

            _mediator = mediator;
            _requestService = requestService;
            _oldStorageId = storageId;

            CancelButton.Click += CloseButton_Click;
        }

        private void SelectStorage_Click(object sender, EventArgs e)
        {
            SelectStorageForm selectStorageForm = new SelectStorageForm(_mediator);
            selectStorageForm.ShowDialog();
            _selectedNewStorage = selectStorageForm.SelectedStorage;
            if (_selectedNewStorage != null)
                NameStorage.Text = _selectedNewStorage.Name;
        }

        private void SelectProduct_Click(object sender, EventArgs e)
        {
            SelectProductsForm selectProductsForm = new SelectProductsForm(_mediator, ref _selectedProducts, _oldStorageId);
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedNewStorage == null || _selectedProducts.Count == 0)
            {
                MessageBox.Show("Выбраны не все элементы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_selectedNewStorage.FreeCapacity < _selectedProducts.Sum(p => p.Key.SpaceOccupied * p.Value))
            {
                MessageBox.Show("Невозможно переместить товары, не хватает места", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите отправить заявку на перемещение продуктов?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _requestService.SendRequestMoving(_selectedProducts, _oldStorageId, _selectedNewStorage.Id);
                Close();
            }
        }



    }
}
