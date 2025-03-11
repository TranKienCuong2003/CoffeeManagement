using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.qrCode
{
    public class QRCodeRequest
    {
        public string accountNo { get; set; }
        public string accountName { get; set; }
        public int acqId { get; set; }
        public decimal amount { get; set; }
        public string addInfo { get; set; }
        public string format { get; set; }
        public string template { get; set; }
    }
}
