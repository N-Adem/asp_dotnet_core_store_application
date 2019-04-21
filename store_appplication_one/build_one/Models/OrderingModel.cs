using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build_one.Models
{
    public class OrderingModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool isAvailable { get; set; }
        
    }
}
