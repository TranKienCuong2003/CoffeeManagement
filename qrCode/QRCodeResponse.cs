using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.qrCode
{
    public class QRCodeResponse
    {
        public string code { get; set; }
        public string desc { get; set; }
        public QRCodeData data { get; set; }
    }
}
