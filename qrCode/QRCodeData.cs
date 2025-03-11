using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.qrCode
{
    public class QRCodeData
    {
        public int acpId { get; set; }
        public string accountName { get; set; }
        public string qrCode { get; set; }
        public string qrDataURL { get; set; }
    }
}
