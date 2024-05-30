using ArmSclad.Core.Entities;
using ArmSclad.Domain.FiltersModels;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.Domain.UseCases.Storages.Commands.AddStorage;
using ArmSclad.Domain.UseCases.Storages.Commands.DeleteStorage;
using ArmSclad.Domain.UseCases.Storages.Commands.UpdateStorage;
using ArmSclad.Domain.UseCases.Storages.Queries.GetStorages;
using ArmSclad.UI.Common;
using ArmSclad.UI.Main.Modules.OperationsViews;
using ArmSclad.UI.Main.Modules.ProductsViews;
using ArmSclad.UI.Main.Modules.StoragesViews.OperationsViews;
using MediatR;

namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    public partial class StoragesForm : Form
    {
        private static IMediator _mediator;
        private static IRequestService _requestService;
        private static int _pageNumber = 0;
        private static int _amountStoragesOnPage = 14;
        private static List<StorageEntity> _storages;
        private static FilterStorages _filter = null;


        public StoragesForm(IMediator mediator, IRequestService requestService)
        {
            InitializeComponent();

            TopLevel = false;

            _mediator = mediator;
            _requestService = requestService;

            StoragesList.SelectedIndexChanged += StoragesList_SelectedIndexChanged;
            PrevPageButton.Click += PreviousPage;
            NextPageButton.Click += NextPage;
            FiltresButton.Click += FiltresButton_Click;
            AddStorageButton.Click += AddStorageButton_Click;
            ShowEmployees.Click += ShowEmployees_Click;
            ShowProducts.Click += ShowProducts_Click;
            SettingsButton.Click += SettingsButton_Click;
            UpdateButton.Click += UpdateButton_Click;
            DeleteButton.Click += DeleteButton_Click;

            SearchMaxCapacity.TextChanged += SearchMaxCapacity_TextChanged;
            SearchMinCapacity.TextChanged += SearchMinCapacity_TextChanged;

            SearchWorkTime.Value = SearchWorkTime.MinDate;
            StorageInfo.Visible = false;

            LoadData();
        }

        private void SearchMinCapacity_TextChanged(object? sender, EventArgs e)
        {
            InputValidate.CheckDigit(ref SearchMinCapacity);
        }

        private void SearchMaxCapacity_TextChanged(object? sender, EventArgs e)
        {
            InputValidate.CheckDigit(ref SearchMaxCapacity);
        }


        private void StoragesList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (StoragesList.SelectedItems.Count != 0)
            {
                StorageInfo.Visible = true;
                StorageEntity selectedStorage = _storages[StoragesList.Items.IndexOf(StoragesList.SelectedItems[0])];

                NameLabel.Text = selectedStorage.Name;
                AddressLabel.Text = selectedStorage.Address;
                OpeningTimeLabel.Text = selectedStorage.OpeningTime.ToString("t");
                ClosingTimeLabel.Text = selectedStorage.ClosingTime.ToString("t");
                CapacityLabel.Text = selectedStorage.Capacity.ToString();
                RemainingCapacityLabel.Text = selectedStorage.OccupiedCapacity.ToString();
                ProgressCapacity.Value = (int)Math.Round((selectedStorage.OccupiedCapacity * 100 / selectedStorage.Capacity).Value);
            }

        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить данный элемент?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                StorageInfo.Visible = false;
                int selectedStorageId = _storages[StoragesList.Items.IndexOf(StoragesList.SelectedItems[0])].Id;

                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new DeleteStorageCommand { StorageId = selectedStorageId });
                        MessageBox.Show("Данные удалены");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка удаления данных", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private void UpdateButton_Click(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void SettingsButton_Click(object? sender, EventArgs e)
        {
            StorageEntity selectedStorage = _storages[StoragesList.Items.IndexOf(StoragesList.SelectedItems[0])];
            InfoStorageForm infoStorageForm = new InfoStorageForm(ref selectedStorage);
            if (infoStorageForm.ShowDialog() == DialogResult.OK)
            {

                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new UpdateStorageCommand { Storage = selectedStorage });
                        MessageBox.Show("Данные обновлены");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка сохранения данных", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });

            }
        }

        private void ShowProducts_Click(object? sender, EventArgs e)
        {
            ProductsOnStorageForm productsForm = new ProductsOnStorageForm(_mediator, _storages[StoragesList.SelectedItems[0].Index].Id);
            productsForm.ShowDialog();
        }

        private void ShowEmployees_Click(object? sender, EventArgs e)
        {
            EmployeesForm usersForm = new EmployeesForm(_mediator, StoragesList.Items.IndexOf(StoragesList.SelectedItems[0]));
            usersForm.ShowDialog();
        }

        private void AddStorageButton_Click(object? sender, EventArgs e)
        {
            StorageEntity newStorage = new StorageEntity();
            InfoStorageForm infoStorageForm = new InfoStorageForm(ref newStorage);
            if (infoStorageForm.ShowDialog() == DialogResult.OK)
            {
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        newStorage.Id = await _mediator.Send(new AddStorageCommand { Storage = newStorage });
                        MessageBox.Show("Данные сохранены");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка сохранения данных", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private void FiltresButton_Click(object? sender, EventArgs e)
        {
            _filter = new FilterStorages();

            if (!string.IsNullOrEmpty(SearchName.Text))
                _filter.SearchName = SearchName.Text;

            if (!string.IsNullOrEmpty(SearchMaxCapacity.Text))
                _filter.MaxCapacity = float.Parse(SearchMaxCapacity.Text);

            if (!string.IsNullOrEmpty(SearchMinCapacity.Text))
                _filter.MinCapacity = float.Parse(SearchMinCapacity.Text);

            if (SearchWorkTime.Value != SearchWorkTime.MinDate)
                _filter.WorkTime = SearchWorkTime.Value;

            LoadData();
        }

        private void NextPage(object? sender, EventArgs e)
        {
            _pageNumber++;
            LoadData();
        }

        private void PreviousPage(object? sender, EventArgs e)
        {
            if (_pageNumber > 0)
            {
                _pageNumber--;
                LoadData();
            }
        }



        private void LoadData()
        {
            _storages = _mediator.Send(new GetStoragesQuery
            {
                FilterStorages = _filter,
                From = _pageNumber * _amountStoragesOnPage,
                To = _amountStoragesOnPage

            }).Result;
            StoragesList.Items.Clear();

            foreach (StorageEntity storage in _storages)
            {
                StoragesList.Items.Add(new ListViewItem(storage.Name));
            }
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            _filter = null;
            SearchMinCapacity.Text = "";
            SearchMaxCapacity.Text = "";
            SearchName.Text = "";
            SearchWorkTime.Value = SearchWorkTime.MinDate;
            LoadData();

        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            int selectedStorageId = _storages[StoragesList.Items.IndexOf(StoragesList.SelectedItems[0])].Id;
            var result = MessageBox.Show("Отправить заявку на проведение инвентаризации?", "Операция", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _requestService.SendRequestInventory(selectedStorageId);
            }
        }

        private void AcceptanceButton_Click(object sender, EventArgs e)
        {
            AcceptanceForm acceptanceForm = new AcceptanceForm(_mediator, _requestService, _storages[StoragesList.SelectedItems[0].Index]);
            acceptanceForm.ShowDialog();
        }

        private void ShipmentButton_Click(object sender, EventArgs e)
        {
            ShipmentForm shipmentForm = new ShipmentForm(_mediator, _requestService, _storages[StoragesList.SelectedItems[0].Index].Id);
            shipmentForm.ShowDialog();
        }

        private void MovingButton_Click(object sender, EventArgs e)
        {
            MoovingForm moovingForm = new MoovingForm(_mediator, _requestService, _storages[StoragesList.SelectedItems[0].Index].Id);
            moovingForm.ShowDialog();
        }

    }
}
