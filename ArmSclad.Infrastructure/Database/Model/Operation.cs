using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class Operation
    {
        [Key]

        public int Id { get; set; }
        public int? TargetId { get; set; }

        public int CreatorId {  get; set; }
        public int Type {  get; set; }
        public int Status { get; set; }
        public int StorageId { get; set; }
        public int EmployeeId { get; set; }


        public DateTime Created { get; set; }
        public DateTime LastModify { get; set; }
    }
}
