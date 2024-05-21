using System.ComponentModel.DataAnnotations;

namespace ArmSclad.Infrastructure.Database.Model
{
    public class Product
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float NumberPackages { get; set; }
        public float NumberPiecesInPackage { get; set; }
        public float SpaceOccupied { get; set; }
        public float Price { get; set; }

        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModify { get; set; }

    }
}
