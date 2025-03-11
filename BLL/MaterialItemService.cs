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
    public class MaterialItemService: IServiceMapping<MaterialItemDTO>
    {
        #region Singleton pattern
        private static MaterialItemService instance;
        public static MaterialItemService Instance
        {
            get
            {
                if (instance == null)
                    instance = new MaterialItemService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public List<MaterialItemDTO> GetAllMaterialItems()
        {
            DataTable dt = MaterialItemDAL.Instance.GetTable();

            return MapToDTOList(dt);
        }

        public List<MaterialItemDTO> SearchMaterialItem(string keyword)
        {
            DataTable dt = MaterialItemDAL.Instance.SearchMaterialItem(keyword);

            return MapToDTOList(dt);
        }

        public List<MaterialItemDTO> GetMaterialItemInRange(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = MaterialItemDAL.Instance.GetMaterialItemInRange(fromDate, toDate);

            return MapToDTOList(dt);
        }

        public MaterialItemDTO MapToDTO(DataRow row)
        {
            return new MaterialItemDTO
            {
                ID = Convert.ToInt32(row["Id"]),
                Material = row["Material"].ToString(),
                Description = row["Description"].ToString(),
                Quantity = Convert.ToInt32(row["Quantity"]),
                Unit = row["Unit"].ToString(),
                Price = Convert.ToInt32(row["Price"]),
                ExpireDate = Convert.ToDateTime(row["ExpireDate"]),
                IsExpired = Convert.ToDateTime(row["ExpireDate"]) < DateTime.Now,
                FormattedExpireDate = Convert.ToDateTime(row["ExpireDate"]).ToString("dd-MM-yyyy"),
            };
        }

        public List<MaterialItemDTO> MapToDTOList(DataTable table)
        {
            var tables = new List<MaterialItemDTO>();

            foreach (DataRow row in table.Rows)
            {
                tables.Add(MapToDTO(row));
            }

            return tables;
        }
    }
}
