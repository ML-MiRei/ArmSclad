using ArmSclad.Core.Enums;

namespace ArmSclad.Core.Entities
{
    public class OperationWithProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public OperationTypeEnum OperationType { get; set; }
        public double Amount { get; set; }
        public int? TargetId { get; set; }
        public string StringTarget
        {
            get
            {
                if (OperationType == OperationTypeEnum.Moving || OperationType == OperationTypeEnum.Shipment)
                    return "склад";
                else if (OperationType == OperationTypeEnum.Acceptance)
                    return "клиент";
                return "";
            }
        }

    }
}
