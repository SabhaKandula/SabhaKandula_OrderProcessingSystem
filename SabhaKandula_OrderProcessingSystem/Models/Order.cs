namespace SabhaKandula_OrderProcessingSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0;
                foreach (var op in OrderProducts)
                {
                    total += op.Product.Price;
                }
                return total;
            }

        }

        public bool CanPlaceOrder()
        {
            return Status != OrderStatus.Unfulfilled;
        }
    }
    public enum OrderStatus
    {
        Pending,
        Unfulfilled,
        Completed
    }
}