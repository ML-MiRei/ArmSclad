using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Operations.Queries.GetOperationsByStorage;
using MediatR;

namespace ArmSclad.UI.Main.Modules.OperationsViews
{
    public partial class OperationsEmployeeForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _operationsOnPage = 27;
        private List<OperationEntity> _operations;
        public OperationsEmployeeForm(IMediator mediator)
        {
            InitializeComponent();
            TopLevel = false;

            _mediator = mediator;
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

        protected override void OnShown(EventArgs e)
        {
            LoadData();
            base.OnShown(e);
        }

        private void LoadData()
        {
            OperationsList.Items.Clear();

            _operations = _mediator.Send(new GetOperationsByStorageQuery
            {
                StorageId = Program.CurrentUser.StorageId.Value,
                From = _pageNumber * _operationsOnPage,
                To = _operationsOnPage,
            }).Result;

            foreach (var operation in _operations)
            {
                OperationsList.Items.Add(new ListViewItem(new string[] {
                  operation.Id.ToString(),
                  operation.Type.ToString(),
                  operation.StorageId.ToString(),
                  operation.CreatorId.ToString(),
                  operation.EmployeeId == null ? String.Empty : operation.EmployeeId.ToString(),
                  operation.StringStatus,
                  operation.StringTarget,
                  operation.TargetId != null ? operation.TargetId.ToString() : ""
                }));

            }
        }

        private void OperationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OperationsList.SelectedItems.Count > 0 && _operations[OperationsList.SelectedItems[0].Index].Status != Core.Enums.OperationStatusEnum.Сancelled)
            {
                InfoOperationForm infoOperationForm = new InfoOperationForm(_mediator, _operations[OperationsList.SelectedItems[0].Index]);
                infoOperationForm.ShowDialog();
            }

        }
    }
}
