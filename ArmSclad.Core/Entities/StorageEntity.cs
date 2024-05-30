namespace ArmSclad.Core.Entities
{
    public class StorageEntity : BaseEntity
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime OpeningTime { get; set; } = DateTime.Now;
        public DateTime ClosingTime { get; set; } = DateTime.Now;
        public double? Capacity { get; set; } = null;
        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();

        //занятое место
        public double? OccupiedCapacity =>  Products.Sum(p => p.AllSpaceOccupied);

        //свободное место
        public double? FreeCapacity =>  Capacity - OccupiedCapacity;

        //проверка вместимости ряда продуктов
        public bool IsEnoughCapacity(params ProductEntity[] products)
        {
            return Capacity - products.Sum(p => p.AllSpaceOccupied) >= 0;
        }

    }
}
