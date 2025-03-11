using DataProvider;
using System;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class BillDAL : DBConnection
    {
        #region Singleton pattern
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private BillDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetListBillByDate(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetListBillByDate @dateCheckIn, @dateCheckOut", new object[] { dateCheckIn, dateCheckOut });
        }

        public DataTable GetBillByDateAndPage(DateTime dateCheckIn, DateTime dateCheckOut, int page)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetBillByDateAndPage @dateCheckIn, @dateCheckOut, @page", new object[] { dateCheckIn, dateCheckOut, page });
        }

        public int GetNumBillByDate(DateTime dateCheckIn, DateTime dateCheckOut)
        {
            object num = SQLQuery.Instance.ExecuteScalar("SP_GetNumBillByDate @dateCheckIn, @dateCheckOut", new object[] { dateCheckIn, dateCheckOut });
            return Convert.ToInt32(num);
        }

        public DataTable GetUncheckBillByTableID(int tableId)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetUncheckBillIDByTableID @idTable", new object[] { tableId });
        }

        public int InsertBill(int id)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            return (int)SQLQuery.Instance.ExecuteScalar("SP_GetMaxIDBill");
        }

        public void Payment(int id, int discount, double totalPrice, int customerMoney, int change, string paymentOption)
        {
            SQLQuery.Instance.ExecuteNonQuery("SP_Payment @idBill, @discount, @totalPrice, @customerMoney, @change, @paymentOption", new object[] { id, discount, totalPrice, customerMoney, change, paymentOption });
        }

        public DataTable GetRevenueInRange(DateTime fromDate, DateTime toDate)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetRevenueInRange @fromDate, @toDate", new object[] { fromDate, toDate });
        }
        
        public DataTable GetSpendingInRange(DateTime fromDate, DateTime toDate)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetSpendingInRange @fromDate, @toDate", new object[] { fromDate, toDate });
        }
    }
}
