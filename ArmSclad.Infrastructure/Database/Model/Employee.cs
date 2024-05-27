using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class Employee
    {
        [Key]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public int Role {  get; set; }
        public int Position {  get; set; }
        public int? StorageId {  get; set; }


        public bool IsActive { get; set; } = true;
 
    }
}
