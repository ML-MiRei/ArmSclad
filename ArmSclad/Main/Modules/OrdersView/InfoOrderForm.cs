using ArmSclad.Core.Entities;
using ArmSclad.UI.Common;
using ArmSclad.UI.Main.Modules.ClientsViews;
using ArmSclad.UI.Main.Modules.ProductsViews;
using MediatR;

namespace ArmSclad.UI.Main.Modules.OrdersView
{
    public partial class InfoOrderForm : Form
    {
        private static IMediator _mediator;
        private Dictionary<ProductEntity, float> _selectedProducts;
        private ClientEntity _selectedClient;
        private OrderEntity _orderEntity;



        public InfoOrderForm(IMediator mediator, ref OrderEntity orderEntity)
        {
            InitializeComponent();

            _selectedClient = orderEntity.Client;
            _mediator = mediator;
            _orderEntity = orderEntity;
            _selectedProducts = new Dictionary<ProductEntity, float>();

            foreach (var product in orderEntity.Products)
            {
                _selectedProducts[product] = (float)product.NumberPackages.Value;
            }


            AddressTextBox.Text = orderEntity.Address;
            if (orderEntity.Client?.FirstName != null)
            {
                NameClient.Text = orderEntity.Client.ShortFullName;
            }
            LoadData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InputValidate.CheckNotEmpty(AddressTextBox))
            {
                _orderEntity.Products = _selectedProducts.Select(p => new ProductEntity { Id = p.Key.Id, NumberPackages = p.Value }).ToList();
                _orderEntity.Client = _selectedClient;
                _orderEntity.Address = AddressTextBox.Text;
                _orderEntity.DeliveryTime = DeliveryDatePicker.Value;

                DialogResult = DialogResult.OK;
            }
        }

        private void SelectClient_Click(object sender, EventArgs e)
        {
            SelectClientForm selectClientForm = new SelectClientForm(_mediator);
            selectClientForm.ShowDialog();
            _selectedClient = selectClientForm.SelectedClient;
            if (_selectedClient != null)
            {
                NameClient.Text = _selectedClient.ShortFullName;
                AddressTextBox.Text = _selectedClient.Address;
            }
        }

        private void SelectProduct_Click(object sender, EventArgs e)
        {
            SelectProductsForm selectProductsForm = new SelectProductsForm(_mediator, ref _selectedProducts, indicatorDifference: false);
            selectProductsForm.ShowDialog();
            LoadData();
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
