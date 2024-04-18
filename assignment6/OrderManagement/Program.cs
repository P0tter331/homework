
using System;
using System.Collections.Generic;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建具体的客户
            var customerTony = new Customer("C001", "Tony Stark");
            var customerSteve = new Customer("C002", "Steve Rogers");

            // 创建具体的产品
            var productMilk = new Product("P001", "Organic Milk", 50m); // 价格为50
            var productBread = new Product("P002", "Whole Wheat Bread", 30m); // 价格为30

            // 创建订单明细
            var orderDetailMilk = new OrderDetails(productMilk, 2); // 2份有机牛奶
            var orderDetailBread = new OrderDetails(productBread, 3); // 3份全麦面包

            // 创建订单并添加订单明细
            var orderTony = new Order("O001", customerTony);
            orderTony.AddOrderDetail(orderDetailMilk);

            var orderSteve = new Order("O002", customerSteve);
            orderSteve.AddOrderDetail(orderDetailBread);

            // 创建OrderService并添加订单
            var orderService = new OrderService();
            orderService.AddOrder(orderTony);
            orderService.AddOrder(orderSteve);

            // 测试查询功能 - 按客户名查询订单
            Console.WriteLine("按客户名查询订单（Tony Stark）：");
            var ordersByCustomerName = orderService.QueryOrders(customerName: "Tony Stark");
            foreach (var order in ordersByCustomerName)
            {
                Console.WriteLine(order);
            }

            // 测试排序功能 - 默认按订单号排序
            Console.WriteLine("\n默认排序（按订单号）：");
            orderService.SortOrders(o => o.OrderId);
            foreach (var order in orderService.GetOrders())
            {
                Console.WriteLine(order);
            }

            // 测试排序功能 - 按总金额排序
            Console.WriteLine("\n按总金额排序：");
            orderService.SortOrders(o => o.TotalAmount);
            foreach (var order in orderService.GetOrders())
            {
                Console.WriteLine(order);
            }
        }
    }
}
