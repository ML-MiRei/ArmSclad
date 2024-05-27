using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class Storage
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpeningTime {  get; set; }
        public DateTime ClosingTime {  get; set; }
        public double Capacity { get; set; }


        public bool IsActive { get; set; } = true;

    }
}
