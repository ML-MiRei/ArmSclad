using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class OperationStatus
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
