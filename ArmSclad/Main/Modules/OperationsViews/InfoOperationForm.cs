using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Operations.Commands.AddOperation;
using ArmSclad.UI.Common;
using MediatR;

namespace ArmSclad.UI.Main.Modules.OperationsViews
{
    public partial class InfoOperationForm : Form
    {
        private static IMediator _mediator;
        private OperationEntity _currentOperation;

        public InfoOperationForm(IMediator mediator, OperationEntity operationEntity)
        {
            InitializeComponent();

            _mediator = mediator;
            _currentOperation = operationEntity;

            if (operationEntity.EmployeeId == null)
            {
                SetSuccsessStatus.Visible = false;
            }
            else if (operationEntity.EmployeeId == Program.CurrentUser.Id)
            {
                Execute.Visible = false;
            }
            else
            {
                Execute.Visible = false;
                SetSuccsessStatus.Visible = false;
            }

            LoadData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите стать исполнителем заявки?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        _currentOperation.Status = Core.Enums.OperationStatusEnum.InProcess;
                        _currentOperation.EmployeeId = Program.CurrentUser.Id;
                        await _mediator.Send(new AddOperationCommand
                        {
                            Operation = _currentOperation
                        });

                        MessageBox.Show("Вы стали исполнителем заявки");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Возникла ошибка при становлении исполнителем заявки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }


        }

        private void SetSuccsessStatus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите подтвердить готовность выполнения заявки?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        _currentOperation.Status = Core.Enums.OperationStatusEnum.Success;
                        await _mediator.Send(new AddOperationCommand
                        {
                            Operation = _currentOperation
                        });

                        MessageBox.Show("Информация о выполнении заявки сохранена");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Возникла ошибка при сохранении информации о выполнении заявки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private void LoadData()
        {
            ProductsList.Items.Clear();

            foreach (var product in _currentOperation.Products)
            {
                ProductsList.Items.Add(new ListViewItem(new string[]
                {
                    product.Id.ToString(),
                    product.Name,
                    product.NumberPackages.ToString()
                }));
            }
        }
    }
}
