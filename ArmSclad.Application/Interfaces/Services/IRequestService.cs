using ArmSclad.Core.Entities;

namespace ArmSclad.Domain.Interfaces.Services
{
    public interface IRequestService
    {
        void SendRequestRepacking(List<ProductEntity> productEntities, int storageId);
        void SendRequestQualityСontrol(List<ProductEntity> productEntities, int storageId);
        void SendRequestInventory(int storageId);
        void SendRequestShipment(Dictionary<ProductEntity, float> products, int storageId, int clientId);
        void SendRequestMoving(Dictionary<ProductEntity, float> products, int oldStorageId, int newStorageId);
        void SendRequestAcceptance(Dictionary<ProductEntity, float> products, int storageId);
        void CancelRequest(OperationEntity operation);
    }
}
