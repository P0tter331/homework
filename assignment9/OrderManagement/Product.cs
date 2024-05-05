using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OrderManagement
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public string Name {  get; set; }
        public decimal Price { get; set; }

        public Product(string productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }
        public override string ToString() 
        {
            return $"Product ID: {ProductId}, Name: {Name}, Price: {Price}";
        }
    }
}
