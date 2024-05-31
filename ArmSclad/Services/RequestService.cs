using ArmSclad.Core.Entities;
using ArmSclad.Core.Enums;
using ArmSclad.Domain.Interfaces.Services;
using ArmSclad.Domain.UseCases.Operations.Commands.AddOperation;
using ArmSclad.UI.Common;
using MediatR;

namespace ArmSclad.UI.Services
{
    internal class RequestService(IMediator mediator) : IRequestService
    {
        public void SendRequestAcceptance(Dictionary<ProductEntity, float> products, int storageId)
        {
            TaskManager.AddTask(async () =>
            {
                try
                {
                    await mediator.Send(new AddOperationCommand
                    {
                        Operation = new OperationEntity
                        {
                            CreatorId = Program.CurrentUser.Id,
                            Products = products.Select(p => new ProductEntity { Id = p.Key.Id, NumberPackages = p.Value }).ToList(),
                            Type = Core.Enums.OperationTypeEnum.Acceptance,
                            StorageId = storageId
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

        public void SendRequestInventory(int storageId)
        {
            TaskManager.AddTask(async () =>
            {
                try
                {
                    await mediator.Send(new AddOperationCommand
                    {
                        Operation = new OperationEntity
                        {
                            CreatorId = Program.CurrentUser.Id,
                            StorageId = storageId,
                            Type = Core.Enums.OperationTypeEnum.Inventory
                        }
                    });
                    MessageBox.Show("Заявка на инвентаризацию отправлена");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка отправки заявки на инвентаризацию");
                }

            });
        }

        public void SendRequestMoving(Dictionary<ProductEntity, float> products, int oldStorageId, int newStorageId)
        {
            TaskManager.AddTask(async () =>
            {
                try
                {
                    await mediator.Send(new AddOperationCommand
                    {
                        Operation = new OperationEntity
                        {
                            CreatorId = Program.CurrentUser.Id,
                            Products = products.Select(p => new ProductEntity { Id = p.Key.Id, NumberPackages = p.Value }).ToList(),
                            Type = Core.Enums.OperationTypeEnum.Moving,
                            StorageId = oldStorageId,
                            TargetId = newStorageId
                        }
                    });
                    MessageBox.Show("Заявка на перемещение успешно отправлена");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка отправки заявки на перемещение", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        public void SendRequestQualityСontrol(List<ProductEntity> productEntities, int storageId)
        {
            TaskManager.AddTask(async () =>
            {
                try
                {
                    await mediator.Send(new AddOperationCommand
                    {
                        Operation = new OperationEntity
                        {
                            CreatorId = Program.CurrentUser.Id,
                            Products = productEntities,
                            Type = Core.Enums.OperationTypeEnum.QualityСontrol,
                            StorageId = storageId,
                        }
                    });
                    MessageBox.Show("Заявка на контроль качества успешно отправлена");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка отправки заявки на контроль качества", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        public void SendRequestRepacking(List<ProductEntity> productEntities, int storageId)
        {
            TaskManager.AddTask(async () =>
            {
                try
                {
                    await mediator.Send(new AddOperationCommand
                    {
                        Operation = new OperationEntity
                        {
                            CreatorId = Program.CurrentUser.Id,
                            Products = productEntities,
                            Type = Core.Enums.OperationTypeEnum.Repackaging,
                            StorageId = storageId,
                        }
                    });
                    MessageBox.Show("Заявка на переупаковку успешно отправлена");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка отправки заявки на переупаковку", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }); 
        }

        public void SendRequestShipment(Dictionary<ProductEntity, float> products, int storageId, int clientId)
        {
            TaskManager.AddTask(async () =>
            {
                try
                {
                    await mediator.Send(new AddOperationCommand
                    {
                        Operation = new OperationEntity
                        {
                            CreatorId = Program.CurrentUser.Id,
                            Products = products.Select(p => new ProductEntity { Id = p.Key.Id, NumberPackages = p.Value }).ToList(),
                            Type = OperationTypeEnum.Shipment,
                            StorageId = storageId,
                            TargetId = clientId
                        }
                    });
                    MessageBox.Show("Заявка на отгрузку успешно отправлена");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка отправки заявки на отгрузку", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }


        public void CancelRequest(OperationEntity operation)
        {
            TaskManager.AddTask(async () =>
            {
                try
                {
                    await mediator.Send(new AddOperationCommand
                    {
                        Operation = new OperationEntity
                        {
                            CreatorId = Program.CurrentUser.Id,
                            Status = OperationStatusEnum.Сancelled,
                            StorageId = operation.StorageId,
                            EmployeeId = operation.EmployeeId,
                            TargetId = operation.TargetId,
                            Type = operation.Type,
                            Id = operation.Id,
                            Products = operation.Products
                        }
                    });

                    MessageBox.Show("Заявка отозвана");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка отзыва заявки");
                }
            });
        }
    }
}
