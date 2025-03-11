using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.BLL
{
    public class BillService : IServiceMapping<BillDTO>
    {
        #region Singleton pattern
        private static BillService instance;
        public static BillService Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public int GetUncheckBillId(int tableId)
        {
            var bills = MapToDTOList(BillDAL.Instance.GetUncheckBillByTableID(tableId));
            if (bills.Count > 0)
            {
                return bills[0].ID;
            }
            return -1;
        }

        public int InsertBill(int id)
        {
            return BillDAL.Instance.InsertBill(id);
        }

        public BillDTO MapToDTO(DataRow row)
        {
            return new BillDTO
            {
                ID = Convert.ToInt32(row["IdBill"]),
                CheckInDate = Convert.ToDateTime(row["DateCheckInBill"]),
                CheckOutDate = row["DateCheckOutBill"] != DBNull.Value ? Convert.ToDateTime(row["DateCheckOutBill"]) : (DateTime?) null,
                Status = Convert.ToBoolean(row["StatusBill"]),
                Discount = Convert.ToInt32(row["Discount"]),
                TotalPrice = Convert.ToDouble(row["TotalPrice"]),
                CustomerMoney = Convert.ToInt32(row["CustomerMoney"]),
                Change = Convert.ToInt32(row["Change"]),
                PaymentOption = row["PaymentOption"].ToString()
            };
        }

        public List<BillDTO> MapToDTOList(DataTable table)
        {
            var bills = new List<BillDTO>();

            foreach (DataRow row in table.Rows)
            {
                bills.Add(MapToDTO(row));
            }

            return bills;
        }

    }
}
