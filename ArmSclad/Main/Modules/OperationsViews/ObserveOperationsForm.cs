using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.Domain.UseCases.Operations.Queries.GetOperations;
using MediatR;

namespace ArmSclad.UI.Main.Modules.OperationsViews
{
    public partial class ObserveOperationsForm : Form
    {
        private static IMediator _mediator;
        private static IRequestService _requestService;
        private int _pageNumber = 0;
        private int _operationsOnPage = 27;
        private List<OperationEntity> _operations;


        public ObserveOperationsForm(IMediator mediator, IRequestService requestService)
        {
            InitializeComponent();
            TopLevel = false;

            _mediator = mediator;
            _requestService = requestService;

            UpdateMode.CheckedChanged += UpdateMode_CheckedChanged;
            LoadData();
        }

        private void UpdateMode_CheckedChanged(object? sender, EventArgs e)
        {
            OperationsList.SelectedItems.Clear();

            if (UpdateMode.Checked)
            {
                OperationsList.SelectedIndexChanged += OperationsList_SelectedIndexChanged;
            }
            else
            {
                OperationsList.SelectedIndexChanged -= OperationsList_SelectedIndexChanged;
            }
        }

        private void OperationsList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (OperationsList.SelectedItems.Count != 0)
            {
                var selectedOperation = _operations[OperationsList.SelectedItems[0].Index];
                if (!new OperationStatusEnum[] { OperationStatusEnum.Сancelled, OperationStatusEnum.Success }.Contains(selectedOperation.Status.Value))
                {
                    var result = MessageBox.Show("Вы уверены, что хотите отозвать заявку?", "", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        _requestService.CancelRequest(selectedOperation);
                    }
                }
            }

        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            if (_pageNumber > 0)
            {
                _pageNumber--;
                LoadData();
            }
        }

        private void UpdatePageButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            _pageNumber++;
            LoadData();
        }


        private void LoadData()
        {
            OperationsList.Items.Clear();

            _operations = _mediator.Send(new GetOperationsQuery
            {
                From = _pageNumber * _operationsOnPage,
                To = _operationsOnPage,
            }).Result;

            foreach (var operation in _operations)
            {
                ListViewItem item = new ListViewItem(new string[] {
                  operation.Id.ToString(),
                  operation.Type.ToString(),
                  operation.StorageId.ToString(),
                  operation.CreatorId.ToString(),
                  operation.EmployeeId == null ? String.Empty : operation.EmployeeId.ToString(),
                  operation.StringStatus,
                  operation.StringTarget,
                  operation.TargetId != null ? operation.TargetId.ToString() : ""
                });

                if (operation.Status == OperationStatusEnum.Сancelled)
                    item.BackColor = Color.Red;
                else if (operation.Status == OperationStatusEnum.Success)
                    item.BackColor = Color.Green;

                OperationsList.Items.Add(item);

            }
        }


    }
}
