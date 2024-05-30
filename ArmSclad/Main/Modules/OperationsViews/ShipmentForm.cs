using ArmSclad.Core.Entities;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.UI.Main.Modules.ClientsViews;
using ArmSclad.UI.Main.Modules.ProductsViews;
using MediatR;

namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    public partial class ShipmentForm : Form
    {
        private static IMediator _mediator;
        private static IRequestService _requestService;
        private int _storageId;
        private Dictionary<ProductEntity, float> _selectedProducts = new Dictionary<ProductEntity, float>();
        private ClientEntity _selectedClient;


        public ShipmentForm(IMediator mediator, IRequestService requestService, int storageId)
        {
            InitializeComponent();

            _mediator = mediator;
            _storageId = storageId;
            _requestService = requestService;

            CancelButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedClient == null || _selectedProducts.Count == 0)
            {
                MessageBox.Show("Выбраны не все элементы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите отправить заявку на отгрузку?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _requestService.SendRequestShipment(_selectedProducts, _storageId, _selectedClient.Id);
                Close();
            }

        }

        private void SelectClient_Click(object sender, EventArgs e)
        {
            SelectClientForm selectClientForm = new SelectClientForm(_mediator);
            selectClientForm.ShowDialog();
            _selectedClient = selectClientForm.SelectedClient;
            if (_selectedClient != null)
                NameClient.Text = _selectedClient.ShortFullName;
        }

        private void SelectProduct_Click(object sender, EventArgs e)
        {
            SelectProductsForm selectProductsForm = new SelectProductsForm(_mediator, ref _selectedProducts, _storageId);
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

        private void LoadData()
        {
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
