using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Clients.Queries.GetClients;
using ArmSclad.Domain.UseCases.Storages.Queries.GetStorages;
using ArmSclad.Infrastructure.Database.Model;
using MediatR;

namespace ArmSclad.UI.Main.Modules.StoragesViews
{
    public partial class SelectStorageForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 15;
        private List<StorageEntity> _storages;
        private StorageEntity _selectedStorage;
        public StorageEntity SelectedStorage { get => _selectedStorage; }



        public SelectStorageForm(IMediator mediator)
        {
            InitializeComponent();

            _mediator = mediator;

            LoadData();
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


        private void LoadData()
        {
            StoragesList.Items.Clear();

            _storages = _mediator.Send(new GetStoragesQuery
            {
                From = _pageNumber * _productsOnPage,
                To = _productsOnPage,
            }).Result;

            foreach (var storage in _storages)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    storage.Id + "",
                    storage.Name,
                    storage.Address,
                    storage.FreeCapacity.ToString(),
                    storage.OpeningTime.ToString("t"),
                    storage.ClosingTime.ToString("t")
                }) ;

                if (Equals(_selectedStorage?.Id, storage.Id))
                    item.Selected = true;

                StoragesList.Items.Add(item);
            }
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void StoragesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StoragesList.SelectedItems.Count != 0)
                _selectedStorage = _storages[StoragesList.SelectedItems[0].Index];
        }
    }
}
