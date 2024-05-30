namespace ArmSclad.Core.Entities
{
    public class OrderEntity : BaseEntity
    {
        public int Id { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string Address { get; set; }
        public ClientEntity Client { get; set; }
        public List<ProductEntity> Products { get; set; } = new List<ProductEntity>();

        //цена за заказ
        public double? Price => Products.Sum(p => p.AllPrice);

        public string Description => string.Join(" ,", Products.Select(p => p.Name + "-" + p.NumberPackages));
    }
}
