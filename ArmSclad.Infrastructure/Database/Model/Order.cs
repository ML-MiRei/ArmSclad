using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class Order
    {
        [Key]

        public int Id { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string Address { get; set; }

        public int ClientId { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
