using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.model
{
    public class BillPayload
    {
        public int BillId { get; set; }
        public int TableId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }
        public List<BillInfoDTO> BillInfos { get; set; }

        public BillPayload(
            int billId, 
            int tableId,
            decimal totalPrice, 
            decimal discount, 
            decimal finalPrice,
            List<BillInfoDTO> BillInfos)
        {
            this.BillId = billId;
            this.TableId = tableId;
            this.TotalPrice = totalPrice;
            this.Discount = discount;
            this.FinalPrice = finalPrice;
            this.BillInfos = BillInfos;
        }
    }
}
