using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BLL
{
    public interface IServiceMapping<T>
    {
        T MapToDTO(DataRow row);
        List<T> MapToDTOList(DataTable table);
    }
}
