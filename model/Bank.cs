using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.model
{
    public class Bank
    {
        public String AccountNo { get; set; }
        public string AccountName { get; set; }
        public int AcqId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LogoPath { get; set; }

        public static List<Bank> LoadExistingBanks()
        {
            List<Bank> banks = new List<Bank>
    {
        new Bank
        {
            AccountNo = "0369702376",
            AccountName = "TRAN KIEN CUONG",
            AcqId = 970422,
            Code = "MB Bank",
            Name = "Ngân hàng TMCP Quân đội",
            LogoPath = @"images/banks/MB.png"
        },
        new Bank
        {
            AccountNo = "120404300703",
            AccountName = "TRAN KIEN CUONG",
            AcqId = 970407,
            Code = "Techcombank",
            Name = "Ngân hàng TMCP Kỹ thương Việt Nam",
            LogoPath = @"images/banks/TCB.png"
        }
    };
            return banks;
        }
    }
}
