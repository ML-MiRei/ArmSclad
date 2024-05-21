namespace ArmSclad.Core.Entities
{
    public class OrderEntity : BaseEntity
    {
        public int Id { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }
        public List<ProductEntity> Products { get; set; }

        //цена за заказ
        public double Price => Products.Sum(p => p.AllPrice);
    }
}
