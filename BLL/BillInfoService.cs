using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BLL
{
    public class BillInfoService : IServiceMapping<BillInfoDTO>
    {
        #region Singleton pattern
        private static BillInfoService instance;
        public static BillInfoService Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public List<BillInfoDTO> GetBillInfosById(int id)
        {
            return MapToDTOList(BillInfoDAL.Instance.GetBillInfoByIdBill(id));
        }

        public bool DeleteBillInfo(int id)
        {
            return BillInfoDAL.Instance.DeleteBillInfo(id) > 0;
        }

        public BillInfoDTO MapToDTO(DataRow row)
        {
            return new BillInfoDTO
            {
                ID = Convert.ToInt32(row["id"]),
                DrinkName = row["drink_name"].ToString(),
                DrinkPrice = Convert.ToDecimal(row["drink_price"]),
                Quantity = Convert.ToInt32(row["quantity"]),
                TotalPrice = Convert.ToDecimal(row["total_price"])
            };
        }

        public List<BillInfoDTO> MapToDTOList(DataTable table)
        {
            var bills = new List<BillInfoDTO>();

            foreach (DataRow row in table.Rows)
            {
                bills.Add(MapToDTO(row));
            }

            return bills;
        }
    }
}
