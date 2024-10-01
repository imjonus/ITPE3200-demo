namespace MyShop.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public decimal OrderItemPrice { get; set; }
        public virtual Item Item { get; set; } = default!;
        public virtual Order Order { get; set; } = default!;
    }
}   