using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class Product
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double NumberPiecesInPackage { get; set; }
        public double SpaceOccupied { get; set; }
        public double Price { get; set; }

        public bool IsActive { get; set; } = true;

    }
}
