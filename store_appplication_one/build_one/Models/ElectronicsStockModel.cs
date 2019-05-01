using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build_one.Models
{
    public class ElectronicsStockModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Price { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        
    }
}
