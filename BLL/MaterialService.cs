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
    public class MaterialService: IServiceMapping<MaterialDTO>
    {

        #region Singleton pattern
        private static MaterialService instance;
        public static MaterialService Instance
        {
            get
            {
                if (instance == null)
                    instance = new MaterialService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public List<MaterialDTO> GetAllMaterials()
        {
            DataTable dt = MaterialDAL.Instance.GetTable();

            return MapToDTOList(dt);
        }

        public List<MaterialDTO> SearchMaterial(string keyword)
        {
            DataTable dt = MaterialDAL.Instance.SearchMaterial(keyword);

            return MapToDTOList(dt);
        }

        public MaterialDTO MapToDTO(DataRow row)
        {
            return new MaterialDTO
            {
                ID = Convert.ToInt32(row["IdMaterial"]),
                Name = row["NameMaterial"].ToString(),
                CreateDate = Convert.ToDateTime(row["CreateDate"]).ToString("dd-MM-yyyy hh:mm:ss")
            };
        }

        public List<MaterialDTO> MapToDTOList(DataTable table)
        {
            var tables = new List<MaterialDTO>();

            foreach (DataRow row in table.Rows)
            {
                tables.Add(MapToDTO(row));
            }

            return tables;
        }
    }
}
