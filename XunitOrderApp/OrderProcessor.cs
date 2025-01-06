namespace XunitOrderApp
{
    public class OrderProcessor
    {
        public decimal CalculateDiscount(Order order)
        {
            if (order.TotalAmount >= 100)
                return order.TotalAmount * 0.1m;
            return 0;
        }

        public bool IsHighValueCustomer(Order order)
        {
            return order.TotalAmount > 500;
        }

        public List<Order> FilterHighValueOrders(List<Order> orders)
        {
            return orders.FindAll(o => IsHighValueCustomer(o));
        }
    }
}
