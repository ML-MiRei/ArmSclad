using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Operations.Commands.AddOperation;
using ArmSclad.UI.Common;
using ArmSclad.UI.Main.Modules.ClientsViews;
using ArmSclad.UI.Main.Modules.ProductsViews;
using MediatR;

namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    public partial class ShipmentForm : Form
    {
        private static IMediator _mediator;
        private int _storageId;
        private List<ProductEntity> _selectedProducts = new List<ProductEntity>();
        private ClientEntity _selectedClient;


        public ShipmentForm(IMediator mediator, int storageId)
        {
            InitializeComponent();

            _mediator = mediator;
            _storageId = storageId;

            ProductsList.DataSource = _selectedProducts;
            CancelButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
                TaskManager.AddTask(async () =>
                            {
                                try
                                {
                                    await _mediator.Send(new AddOperationCommand
                                    {
                                        Operation = new OperationEntity
                                        {
                                            CreatorId = Program.CurrentUser.Id,
                                            Products = _selectedProducts,
                                            TargetId = _selectedClient.Id,
                                            Type = Core.Enums.OperationTypeEnum.Shipment,
                                            StorageId = _storageId
                                        }
                                    });

                                    MessageBox.Show("Заявка на отгрузку успешно отправлена");
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Ошибка отправки заявки на отгрузку");
                                }
                            });
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
        }

    }
}
