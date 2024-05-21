using ArmSclad.Core.Enums;

namespace ArmSclad.Core.Entities
{
    public class EmployeeEntity : PeopleEntity
    {
        public EmployeeRoleEnum Role {  get; set; }
        public string Position {  get; set; }
        public int StorageId { get; set; }
        public string Password { get; set; }

    }
}
