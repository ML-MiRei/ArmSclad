using ArmSclad.Core.Enums;

namespace ArmSclad.Core.Entities
{
    public class OperationEntity : BaseEntity
    {
        public int? TargetId { get; set; }
        public int CreatorId { get; set; }
        public int StorageId { get; set; }
        public int? EmployeeId { get; set; }

        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();

        public OperationTypeEnum Type { get; set; }
        public OperationStatusEnum? Status { get; set; }


        public string StringTarget
        {
            get
            {
                switch (Type)
                {
                    case OperationTypeEnum.Moving:
                        return "склад";
                    case OperationTypeEnum.Shipment:
                        return "клиент";
                    default:
                        return "";
                }
            }
        }

        public string StringStatus
        {
            get
            {
                switch (Status)
                {
                    case OperationStatusEnum.InProcess:
                        return "в работе";
                    case OperationStatusEnum.Success:
                        return "выполнено";
                    case OperationStatusEnum.Waiting:
                        return "ожидание";
                    case OperationStatusEnum.Сancelled:
                        return "отменено";
                    default:
                        return "";
                }
            }
        }
    }
}
