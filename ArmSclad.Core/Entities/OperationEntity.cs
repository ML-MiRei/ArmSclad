using ArmSclad.Core.Enums;

namespace ArmSclad.Core.Entities
{
    public class OperationEntity : BaseEntity
    {
        public int? TargetId { get; set; }
        public int CreatorId { get; set; }
        public int StorageId { get; set; }
        public int EmployeeId { get; set; }


        public OperationTypeEnum Type { get; set; }
        public OperationStatusEnum Status { get; set; }
    }
}
