using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DTO
{
    public class TableDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public TableDTO(int id, string name, string status)
        {
            ID = id;
            Name = name;
            Status = status;
        }

        public TableDTO() { }
    }
}
