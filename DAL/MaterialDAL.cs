using DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAL
{
    public class MaterialDAL: DBConnection
    {
        #region Singleton pattern
        private static MaterialDAL instance;
        public static MaterialDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new MaterialDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private MaterialDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public bool InsertMaterial(string nameMaterial)
        {
            return SQLQuery.Instance.ExecuteNonQuery("[SP_InsertMaterial] @nameMaterial", new object[] { nameMaterial }) > 0;
        }

        public DataTable GetTable()
        {
            return SQLQuery.Instance.GetTable("Material");
        }

        public bool UpdateMaterial(int idMaterial, string nameMaterial)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_UpdateMaterial @idMaterial, @nameMaterial", new object[] { idMaterial, nameMaterial }) > 0;
        }

        public DataTable SearchMaterial(string keyword)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_SearchMaterial @keyword", new object[] { keyword });
        }

        public bool DeleteMaterial(int idMetarial)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_DeleteMaterial @idMetarial", new object[] { idMetarial }) > 0;
        }
    }
}
