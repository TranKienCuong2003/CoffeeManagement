using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class BillInfoDTO
    {
        public int ID { get; set; }
        public string DrinkName { get; set; }
        public decimal DrinkPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
