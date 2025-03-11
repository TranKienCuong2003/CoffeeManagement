using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoffeeManagement.BLL
{
    public class AccountService : IServiceMapping<AccountDTO>
    {

        #region Singleton pattern
        private static AccountService instance;
        public static AccountService Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public bool isLoginSucess(string username, string password)
        {
            return AccountDAL.Instance.CountByUsernameAndPassword(username, password) > 0;
        }

        public AccountDTO GetAccountByUsername(string username)
        {
            return MapToDTO(AccountDAL.Instance.GetAccountByUsername(username));
        }

        public bool ResetPassword(string username)
        {
            var user = GetAccountByUsername(username);

            if (user.DateOfBirth == null)
                return false;

            DateTime date = user.DateOfBirth ?? DateTime.Now;
            string defaultPassword = date.ToString("ddMMyyyy");
            return ResetPassword(username, defaultPassword, true);
        }

        public bool ResetPassword(string username, string password, bool forceResetPassword)
        {
            return AccountDAL.Instance.ResetPassword(username, password, forceResetPassword) > 0;
        }

        public bool InsertAccount(string username, string displayName, string access, DateTime dateOfBirth)
        {
            string password = dateOfBirth.ToString("ddMMyyyy");
            return AccountDAL.Instance.InsertAccount(username, displayName, password, access, dateOfBirth.ToString()) > 0;
        }

        public bool EditAccount(string username, string displayName, string access, DateTime dateOfBirth)
        {
            return AccountDAL.Instance.EditAccount(username, displayName, access, dateOfBirth.ToString()) > 0;
        }

        public List<AccountDTO> GetAllAccounts() {
            return MapToDTOList(AccountDAL.Instance.GetAccount());
        }

        public AccountDTO MapToDTO(DataRow row)
        {
            return new AccountDTO
            {
                Username =row["Username"].ToString(),
                DisplayName = row["DisplayName"].ToString(),
                Password = row["Password"].ToString(),
                Access = row["Access"].ToString(),
                DateOfBirth = row["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(row["DateOfBirth"]) : (DateTime?)null,
                ForceResetPassword = Convert.ToBoolean(row["ForceResetPassword"])
            };
        }
        public List<AccountDTO> MapToDTOList(DataTable table)
        {
            var tables = new List<AccountDTO>();

            foreach (DataRow row in table.Rows)
            {
                tables.Add(MapToDTO(row));
            }

            return tables;
        }
    }
}
