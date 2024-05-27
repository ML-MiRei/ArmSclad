using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Operations.Commands.AddOperation;
using ArmSclad.UI.Common;
using ArmSclad.UI.Main.Modules.ProductsViews;
using ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews.DataSourseModel;
using MediatR;

namespace ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews
{
    public partial class AcceptanceForm : Form
    {
        private static IMediator _mediator;
        private int _storageId;
        private List<ProductEntity> _selectedProducts = new List<ProductEntity>();
        private List<SelectedProductModel> _selectedProductsModels = new List<SelectedProductModel>();

        public AcceptanceForm(IMediator mediator, int storageId)
        {
            InitializeComponent();

            _mediator = mediator;
            _storageId = storageId;

            CancelButton.Click += CloseButton_Click;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            ProductsList.DataSource = _selectedProductsModels;
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

            var result = MessageBox.Show("Вы уверены, что хотите отправить заявку на погрузку?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                bool isQualityСontrol = checkBox1.Checked;
                bool isRepackaging = checkBox2.Checked;

                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new AddOperationCommand
                        {
                            Operation = new OperationEntity
                            {
                                CreatorId = Program.CurrentUser.Id,
                                Products = _selectedProductsModels.Select(p => new ProductEntity { Id = int.Parse(p.ID), NumberPackagesOnStorage = p.Amount }).ToList(),
                                Type = Core.Enums.OperationTypeEnum.Acceptance,
                                StorageId = _storageId,
                            }
                        });
                        MessageBox.Show("Заявка на погрузку успешно отправлена");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка отправки заявки на погрузку", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private void SelectProducts_Click(object sender, EventArgs e)
        {
            SelectProductsForm selectProductsForm = new SelectProductsForm(_mediator, ref _selectedProducts);
            selectProductsForm.ShowDialog();
        }
    }
}
