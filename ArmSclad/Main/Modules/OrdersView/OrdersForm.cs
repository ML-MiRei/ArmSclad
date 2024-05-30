using ArmSclad.Core.Entities;
using ArmSclad.Domain.UseCases.Orders.Commands.AddOrder;
using ArmSclad.Domain.UseCases.Orders.Commands.DeleteOrder;
using ArmSclad.Domain.UseCases.Orders.Commands.UpdateOrder;
using ArmSclad.Domain.UseCases.Orders.Queries.GetOrders;
using ArmSclad.UI.Common;
using MediatR;

namespace ArmSclad.UI.Main.Modules.OrdersView
{
    public partial class OrdersForm : Form
    {
        private static IMediator _mediator;
        private int _pageNumber = 0;
        private int _ordersOnPage = 17;
        private List<OrderEntity> _orders;

        public OrdersForm(IMediator mediator)
        {
            InitializeComponent();
            TopLevel = false;
            _mediator = mediator;

            UpdateMode.CheckedChanged += UpdateMode_CheckedChanged;
            LoadData();
        }

        private void OrdersList_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (OrdersList.SelectedItems.Count > 0)
            {
                OrderEntity orderEntity = _orders[OrdersList.SelectedItems[0].Index];
                InfoOrderForm infoOrderForm = new(_mediator, ref orderEntity);
                if (infoOrderForm.ShowDialog() == DialogResult.OK)
                {
                    TaskManager.AddTask(async () =>
                    {
                        try
                        {
                            await _mediator.Send(new UpdateOrderCommand { Order = orderEntity });
                            MessageBox.Show("Информация о заказе успешно обновлена");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка обновления информации о заказе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                }
            }

        }

        private void UpdateMode_CheckedChanged(object? sender, EventArgs e)
        {
            OrdersList.SelectedItems.Clear();
            if (UpdateMode.Checked)
            {
                OrdersList.SelectedIndexChanged += OrdersList_SelectedIndexChanged;
            }
            else
            {
                OrdersList.SelectedIndexChanged -= OrdersList_SelectedIndexChanged;
            }
        }


        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            if(OrdersList.SelectedItems.Count > 0)
            {
                int selectedOrderId = _orders[OrdersList.SelectedItems[0].Index].Id;
                var result = MessageBox.Show("Вы уверены, что хотите удалить информацию о заказе?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    TaskManager.AddTask(async () =>
                    {
                        try
                        {
                            await _mediator.Send(new DeleteOrderCommand { OrderId = selectedOrderId });
                            MessageBox.Show("Информация о заказе успешно удалена");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка удаления информации о заказе", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    });
                }
            }
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            OrderEntity orderEntity = new OrderEntity();
            InfoOrderForm infoOrderForm = new InfoOrderForm(_mediator, ref orderEntity);
            if (infoOrderForm.ShowDialog() == DialogResult.OK)
            {
                TaskManager.AddTask(async () =>
                {
                    try
                    {
                        await _mediator.Send(new AddOrderCommand { Order = orderEntity });
                        MessageBox.Show("Заказ успешно оформлен");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка оформления заказа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            }
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            _pageNumber++;
            LoadData();
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

        private void LoadData()
        {
            OrdersList.Items.Clear();

            _orders = _mediator.Send(new GetOrdersQuery
            {
                From = _pageNumber * _ordersOnPage,
                To = _ordersOnPage,
            }).Result;

            foreach (var order in _orders)
            {
                OrdersList.Items.Add(new ListViewItem(new string[] {
                    order.Id + "",
                    order.Client.Id.ToString(),
                    order.Description,
                    order.Address,
                    order.DeliveryTime.ToString("f"),
                    order.Price.ToString()
                }));
            }
        }
    }
}
