using DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAL
{
    public class MaterialItemDAL : DBConnection
    {
        #region Singleton pattern
        private static MaterialItemDAL instance;
        public static MaterialItemDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new MaterialItemDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private MaterialItemDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public bool InsertMaterialItem(string material, string description, int quantity, string unit, int price, DateTime expireDate)
        {
            return SQLQuery.Instance.ExecuteNonQuery("[SP_InsertMaterialItem] @material, @description, @quantity, @unit, @price, @expireDate", 
                new object[] {
                    material,
                    description,
                    quantity,
                    unit,
                    price,
                    expireDate
                }) > 0;
        }

        public bool UpdateMaterialItem(int id, string material, string description, int quantity, string unit, int price, DateTime expireDate)
        {
            return SQLQuery.Instance.ExecuteNonQuery("[SP_UpdateMaterialItem] @id, @material, @description, @quantity, @unit, @price, @expireDate",
                new object[] {
                    id,
                    material,
                    description,
                    quantity,
                    unit,
                    price,
                    expireDate
                }) > 0;
        }

        public DataTable GetTable()
        {
            return SQLQuery.Instance.GetTable("MaterialItem");
        }

        public DataTable SearchMaterialItem(string keyword)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_SearchMaterialIteam @keyword", new object[] { keyword });
        }

        public bool DeleteMaterialItem(int id)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_DeleteMaterialItem @id", new object[] { id }) > 0;
        }

        public DataTable GetMaterialItemInRange(DateTime fromDate, DateTime toDate)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetMaterialItemsInRange @fromDate, @toDate", new object[] { fromDate, toDate });
        }
    }
}
