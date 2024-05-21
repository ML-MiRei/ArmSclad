namespace ArmSclad.Core.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float NumberPackages { get; set; }
        public float NumberPiecesInPackage { get; set; }

        //занимаемое пространство одной упаковкой
        public float SpaceOccupied { get; set; }

        //всё занимаемое пространство
        public float AllSpaceOccupied => SpaceOccupied * NumberPackages;

        //цена за единицу товара
        public float Price { get; set; }

        //цена за упаковку
        public float PricePackage => Price * NumberPiecesInPackage;

        //цена за весь товар на складе
        public float AllPrice => PricePackage * NumberPackages;


    }
}
