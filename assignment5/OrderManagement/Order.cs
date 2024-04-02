﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Order
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

        public Order(string orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
        }

        public decimal TotalAmount => OrderDetails.Sum(selector: od => od.TotalPrice);

        public void AddOrderDetail(OrderDetails orderDetail)
        {
            if (!OrderDetails.Contains(orderDetail))
            {
                OrderDetails.Add(orderDetail);
            }
        }

        public override string ToString()
        {
            string detailsStr = string.Join("\n", OrderDetails);
            return $"Order ID: {OrderId}, Customer: {Customer}\nOrder Details:\n{detailsStr}\nTotal Amount: {TotalAmount}";
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId);
        }
    }
}
