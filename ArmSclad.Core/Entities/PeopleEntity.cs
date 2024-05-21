namespace ArmSclad.Core.Entities
{
    public class PeopleEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FullName => LastName + " " + FirstName + " " + SecondName;
        public string ShortFullName => FirstName[0] + "." + SecondName + ". " + LastName;
    }
}
