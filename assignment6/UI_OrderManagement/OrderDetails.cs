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
        public override bool Equals(object obj)
        {
            OrderDetails other = obj as OrderDetails; // 尝试将obj转换为OrderDetails类型
            if (other == null) return false; // 如果转换失败，则返回false

            return
                EqualityComparer<Product>.Default.Equals(this.Product, other.Product) &&
                this.Quantity == other.Quantity;
        }

        public override int GetHashCode()
        {
            unchecked // 溢出时忽略，因为我们只关心低位
            {
                int hash = 17; // 选择一个质数来开始
                               // 对每一个字段，选择一个质数与字段的哈希码结合
                hash = hash * 23 + (Product != null ? Product.GetHashCode() : 0);
                hash = hash * 23 + Quantity.GetHashCode();
                return hash;
            }
        }
    }
}
