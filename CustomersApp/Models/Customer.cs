namespace CustomersApp.Models;
using CustomersApp.Models.SharedProp;
    public class Customer : BaseProp
    {
        public int CustomerId {  get; set; }    
        public string CustomerName { get; set; } 
        public string CustomerEmail { get; set; }
    public string CustomerCity { get; set; }
        public int Phone {  get; set; } 

    }