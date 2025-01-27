namespace CustomersApp.Models;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CustomersApp.Models.SharedProp;
    public class Customer : BaseProp
    {
    [Display(Name = "Customer ID")]
    public int CustomerId {  get; set; }
    [Display(Name = "Customer Name")]

    public string CustomerName { get; set; }
    [Display(Name = "Customer Email")]

    public string CustomerEmail { get; set; }
    [Display(Name = "City")]

    public string CustomerCity { get; set; }

    [Display(Name ="Phone Number")]
    public int Phone {  get; set; } 

    }
