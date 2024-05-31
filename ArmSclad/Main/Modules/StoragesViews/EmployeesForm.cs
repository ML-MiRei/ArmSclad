using ArmSclad.Domain.UseCases.Employees.Queries.GetEmployeesByStorage;
using MediatR;

namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    public partial class EmployeesForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _employyesOnPage = 15;
        private int _storageId;


        public EmployeesForm(IMediator mediator, int storageId)
        {
            InitializeComponent();

            _mediator = mediator;
            _storageId = storageId;

            LoadData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            _pageNumber++;
            LoadData();
        }

        private void UpdatePageButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            if (_pageNumber > 0)
            {
                _pageNumber--;
                LoadData();
            }
        }

        public void LoadData()
        {
            var employees = _mediator.Send(new GetEmployeesByStorageQuery
            {
                From = _pageNumber * _employyesOnPage,
                To = _employyesOnPage,
                StorageId = _storageId
            }).Result;

            foreach (var employee in employees)
            {
                EmployeesList.Items.Add(new ListViewItem(new string[] { employee.Id + "", employee.FullName, employee.Position }));
            }
        }
    }
}
