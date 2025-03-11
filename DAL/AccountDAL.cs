using DataProvider;
using System.Data;

namespace CoffeeManagement.DAL
{
    public class AccountDAL : DBConnection
    {
        #region Singleton pattern
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAL() { SQLQuery.Instance.connectionString = connect; }
        #endregion

        public DataTable GetAccount()
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetAccount");
        }

        public int CountByUsernameAndPassword(string username, string password)
        {
            return (int)SQLQuery.Instance.ExecuteScalar("SP_IsLogin @username, @password", new object[] { username, password });
        }

        public DataRow GetAccountByUsername(string username)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_GetAccountByUsername @username", new object[] { username }).Rows[0];
        }

        public bool UpdateAccount(string username, string displayName, string password, string newPassword)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_UpdateAccount @username, @displayName, @password, @newPassword", new object[] { username, displayName, password, newPassword }) > 0;
        }

        public DataTable SearchAccount(string keyword)
        {
            return SQLQuery.Instance.ExecuteQuery("SP_SearchAccount @keyword", new object[] { keyword });
        }

        public int InsertAccount(string username, string displayName, string password, string access, string dateOfBirth)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_InsertAccount @username, @displayName, @password, @access, @dateOfBirth", new object[] { username, displayName, password, access, dateOfBirth });
        }

        public int EditAccount(string username, string displayName, string access, string dateOfBirth)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_EditAccount @username, @displayName, @access, @dateOfBirth", new object[] { username, displayName, access, dateOfBirth });
        }

        public bool DeleteAccount(string username)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_DeleteAccount @username", new object[] { username }) > 0;
        }

        public int ResetPassword(string username, string password, bool forceResetPassword)
        {
            return SQLQuery.Instance.ExecuteNonQuery("SP_ResetPassword @username, @password, @forceResetPassword", new object[] { username, password, forceResetPassword });
        }
    }
}