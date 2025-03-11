using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class MaterialItemDTO
    {
        public int ID { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int Price { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsExpired { get; set; }
        public string FormattedExpireDate { get; set; }
    }
}
