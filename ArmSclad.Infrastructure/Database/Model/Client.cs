using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        public int Status {  get; set; }


        public bool IsActive { get; set; } = true;

    }
}
