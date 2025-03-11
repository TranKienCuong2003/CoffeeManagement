using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class BillDTO
    {
        public int ID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public bool Status { get; set; }
        public int Discount { get; set; }
        public double TotalPrice { get; set; }
        public int CustomerMoney { get; set; }
        public int Change { get; set; }
        public string PaymentOption { get; set; }
    }
}
