namespace ArmSclad.Core.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double? NumberPackages { get; set; } = null;
        public double? NumberPiecesInPackage { get; set; } = null;

        //занимаемое пространство одной упаковкой
        public double? SpaceOccupied { get; set; } = null;

        //всё занимаемое пространство
        public double? AllSpaceOccupied => SpaceOccupied * NumberPackages;

        //цена за единицу товара
        public double? Price { get; set; } = null;

        //цена за упаковку
        public double? PricePackage => Price * NumberPiecesInPackage;

        //цена за весь товар на складе
        public double? AllPrice => PricePackage * NumberPackages;

    }
}
