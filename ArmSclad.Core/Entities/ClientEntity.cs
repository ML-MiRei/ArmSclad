using ArmSclad.Core.Enums;

namespace ArmSclad.Core.Entities
{
    public class ClientEntity : PeopleEntity
    {
        public string Address { get; set; }
        public ClientStatusEnum Status { get; set; }

    }
}
