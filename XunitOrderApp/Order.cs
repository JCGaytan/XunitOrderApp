namespace XunitOrderApp
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual decimal TotalAmount { get; set; }
    }
}
