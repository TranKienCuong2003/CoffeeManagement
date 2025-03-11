using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using DataProvider;

namespace CoffeeManagement.BLL
{
    public class TableService : IServiceMapping<TableDTO>
    {
        #region Singleton pattern
        private static TableService instance;
        public static TableService Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public List<TableDTO> GetAllTables()
        {
            DataTable dt = TableDAL.Instance.GetTable();

            return MapToDTOList(dt);
        }

        public void SwitchTable(int id1, int id2)
        {
            TableDAL.Instance.SwitchTable(id1, id2);
        }

        public void MergeTable(int id1, int id2)
        {
            TableDAL.Instance.MergeTable(id1, id2);
        }
        public TableDTO MapToDTO(DataRow row)
        {
            return new TableDTO
            {
                ID = Convert.ToInt32(row["IdTable"]),
                Name = row["NameTable"].ToString(),
                Status = row["StatusTable"].ToString()
            };
        }

        public List<TableDTO> MapToDTOList(DataTable table)
        {
            var tables = new List<TableDTO>();

            foreach (DataRow row in table.Rows)
            {
                tables.Add(MapToDTO(row));
            }

            return tables;
        }
    }
}
