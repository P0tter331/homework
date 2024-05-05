using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement_UI;

namespace OrderManagement
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>(); // 确保在声明时初始化列表


        // 获取订单列表的只读副本
        public IReadOnlyList<Order> GetOrders()
        {
            return orders.AsReadOnly();
        }

        // 添加订单
        public void AddOrder(Order order)
        {
            using (var context = new OrderContext())
            {
                if (context.Orders.Any(o => o.OrderId == order.OrderId))
                {
                    throw new ArgumentException($"Order with ID {order.OrderId} already exists.");
                }
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }


        // 删除订单
        public void RemoveOrder(string orderId)
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order == null)
                {
                    throw new ArgumentException($"Order with ID {orderId} does not exist.");
                }
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }

        // 查询订单
        public List<Order> QueryOrders(string orderId = null, string customerName = null, string productName = null, decimal? minTotalAmount = null)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders.AsQueryable();

                if (!string.IsNullOrEmpty(orderId))
                    query = query.Where(o => o.OrderId == orderId);
                if (!string.IsNullOrEmpty(customerName))
                    query = query.Where(o => o.Customer.Name == customerName);
                if (!string.IsNullOrEmpty(productName))
                    query = query.Where(o => o.OrderDetails.Any(d => d.Product.Name == productName));
                if (minTotalAmount.HasValue)
                    query = query.Where(o => o.TotalAmount >= minTotalAmount.Value);

                return query.ToList();
            }
        }

        // 排序订单
        // 允许使用Lambda表达式作为排序的键选择器
        // 可以按订单号、总金额等进行排序
        public void SortOrders(Func<Order, object> keySelector)
        {
            orders = orders.OrderBy(keySelector).ToList();
        }

        //根据订单ID排序
        //orderService.SortOrders(order => order.OrderId);





    }
}
