using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public Customer()
        {
            Name = "Default Name";
            CustomerId = "Default ID";
        }
        public Customer(string customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

    public override string ToString()
    {
        return $"Customer ID: {CustomerId}, Name: {Name}";
    }
}
}
