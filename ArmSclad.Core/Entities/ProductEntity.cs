namespace ArmSclad.Core.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double? NumberPackagesOnStorage { get; set; } = null;
        public double? NumberPiecesInPackage { get; set; } = null;

        //занимаемое пространство одной упаковкой
        public double? SpaceOccupied { get; set; } = null;

        //всё занимаемое пространство
        public double? AllSpaceOccupied => SpaceOccupied * NumberPackagesOnStorage;

        //цена за единицу товара
        public double? Price { get; set; } = null;

        //цена за упаковку
        public double? PricePackage => Price * NumberPiecesInPackage;

        //цена за весь товар на складе
        public double? AllPrice => PricePackage * NumberPackagesOnStorage;

    }
}
