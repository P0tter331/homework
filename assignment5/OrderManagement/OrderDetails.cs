using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class OrderDetails
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        //public decimal TotalPrice => Product.Price*Quantity;
        public decimal TotalPrice { get =>Product.Price*Quantity; }

        public OrderDetails(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public override bool Equals(object? obj)
        {
            return obj is OrderDetails other && 
                EqualityComparer<Product>.Default.Equals(Product, other.Product) &&
       Quantity == other.Quantity;           
        }

        public override int GetHashCode()
        {
            // 实现GetHashCode方法
            return HashCode.Combine(Product, Quantity);
        }
    }
}
