using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        // 如果订单已存在（根据订单ID判断），则抛出异常
        public void AddOrder(Order order)
        {
            // 检查传入的order是否为null
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Order cannot be null.");
            }
            if (orders.Any(o=>o.OrderId==order.OrderId))
            {
                throw new ArgumentException($"Order with ID {order.OrderId} already exists.");
            }
            orders.Add(order);
        }


        // 删除订单
        // 如果订单不存在（根据订单ID判断），则抛出异常
        public void RemoveOrder(string orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                throw new ArgumentException($"Order with ID {orderId} does not exist.");
            }
            orders.Remove(order);
        }

        // 查询订单
        // 支持根据订单ID、客户名、商品名、最小总金额等条件进行查询
        // 查询结果按照订单的总金额排序
        public List<Order> QueryOrders(string orderId = null, string customerName = null, string productName = null, decimal? minTotalAmount = null)
        {
            var query = orders.AsQueryable();

            if (!string.IsNullOrEmpty(orderId))
            {
                query = query.Where(o => o.OrderId == orderId);
            }
            if (!string.IsNullOrEmpty(customerName))
            {
                query = query.Where(o => o.Customer.Name == customerName);
            }
            if (!string.IsNullOrEmpty(productName))
            {
                query = query.Where(o => o.OrderDetails.Any(d => d.Product.Name == productName));
            }
            if (minTotalAmount.HasValue)
            {
                query = query.Where(o => o.TotalAmount >= minTotalAmount.Value);
            }

            return query.OrderBy(o => o.TotalAmount).ToList();
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
