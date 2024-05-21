using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class ClientStatus
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
