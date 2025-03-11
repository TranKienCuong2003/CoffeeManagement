using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class AccountDTO
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string  Access { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool ForceResetPassword;
    }
}
