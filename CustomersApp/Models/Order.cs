namespace CustomersApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; } 
        public string Product {  get; set; }
        public int Amount { get; set; } 
        public int CustomerId { get; set; }

    }
}
