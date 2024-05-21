namespace ArmSclad.Core.Entities
{
    public class StorageEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public float Capacity { get; set; }
        public List<ProductEntity> Products { get; set; }

        //свободно место
        public double RemainingCapacity => Capacity - Products.Sum(p => p.AllSpaceOccupied);

        //проверка вместимости ряда продуктов
        public bool IsEnoughCapacity(params ProductEntity[] products)
        {
            return Capacity - products.Sum(p => p.AllSpaceOccupied) >= 0;
        }

    }
}
