using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Clients.Commands.AddClient;
using ArmSclad.Domain.UseCases.Clients.Commands.DeleteClient;
using ArmSclad.Domain.UseCases.Clients.Commands.UpdateClient;
using ArmSclad.Domain.UseCases.Clients.Queries.GetClients;
using ArmSclad.UI.Common;
using MediatR;

namespace ArmSclad.UI.Main.Modules.ClientsViews
{
    public partial class ClientsForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _productsOnPage = 17;
        private List<ClientEntity> _clients;

        public ClientsForm(IMediator mediator)
        {
            InitializeComponent();
            TopLevel = false;

            _mediator = mediator;
            ClientsList.SelectedIndexChanged += ClientsList_SelectedIndexChanged;
            UpdateMode.CheckStateChanged += UpdateMode_CheckStateChanged;

            LoadData();
        }

        private void UpdateMode_CheckStateChanged(object? sender, EventArgs e)
        {
            ClientsList.SelectedItems.Clear();
        }

        private void ClientsList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (UpdateMode.Checked && ClientsList.SelectedItems.Count != 0)
            {
                ClientEntity selectedClient = _clients[ClientsList.SelectedItems[0].Index];
                InfoClientForm infoClientForm = new InfoClientForm(ref selectedClient);
                var result = infoClientForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TaskManager.AddTask(async () =>
                    {
                        try
                        {
                            await _mediator.Send(new UpdateClientCommand { ClientEntity = selectedClient });
                            MessageBox.Show("Информация о клиенте успешно обновлена");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошобка при сохранении информации о клиенте", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                }
            }
        }


        private void PrevPageButton_Click(object sender, EventArgs e)
        {
            _pageNumber--;
            LoadData();
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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ClientEntity selectedClient = new ClientEntity();
            InfoClientForm infoClientForm = new InfoClientForm(ref selectedClient);
            var result = infoClientForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new AddClientCommand { ClientEntity = selectedClient });
                        MessageBox.Show("Информация о клиенте успешно добавлена");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошобка при сохранении информации о клиенте", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите удалить информацию о клиенте?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int selectedClientId = _clients[ClientsList.SelectedItems[0].Index].Id;
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new DeleteClientCommand { ClientId = selectedClientId });
                        MessageBox.Show("Информация о клиенте успешно удалена");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошобка при удалении информации о клиенте", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                });
            }

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
                ClientsList.Items.Add(new ListViewItem(new string[] {
                    client.Id + "",
                    client.FullName,
                    client.Phone,
                    client.Email,
                    client.Address,
                    client.Status == Core.Enums.ClientStatusEnum.Organization ? "Юр. лицо" : "Физ. лицо"
                }));
            }
        }

    }
}
