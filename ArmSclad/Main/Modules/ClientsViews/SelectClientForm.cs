using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Clients.Queries.GetClients;
using MediatR;

namespace ArmSclad.UI.Main.Modules.ClientsViews
{
    public partial class SelectClientForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 15;
        private List<ClientEntity> _clients;
        private ClientEntity _selectedClient;
        public ClientEntity SelectedClient { get => _selectedClient; }

        public SelectClientForm(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;

            ClientsList.SelectedIndexChanged += ClientsList_SelectedIndexChanged;

            LoadData();
        }

        private void ClientsList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if(ClientsList.SelectedItems.Count != 0)
                _selectedClient = _clients[ClientsList.SelectedItems[0].Index];
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
            _pageNumber--;
            LoadData();
        }


        private void LoadData()
        {
            ClientsList.Items.Clear();

            _clients = _mediator.Send(new GetClientsQuery
            {
                From = _pageNumber * _productsOnPage,
                To = _productsOnPage,
            }).Result;

            foreach (var client in _clients)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    client.Id + "",
                    client.FullName,
                    client.Phone,
                    client.Email,
                    client.Address,
                    client.Status == Core.Enums.ClientStatusEnum.Organization ? "Юр. лицо" : "Физ. лицо"
                });

                if (Equals(_selectedClient?.Id, client.Id))
                    item.Selected = true;

                ClientsList.Items.Add(item);
            }
        }


        private void ContinueButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
