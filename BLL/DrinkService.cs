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
    public class DrinkService
    {
        #region Singleton pattern
        private static DrinkService instance;
        public static DrinkService Instance
        {
            get
            {
                if (instance == null)
                    instance = new DrinkService();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion

        public List<DrinkAnalyticsItem> GetDrinkAnalytis(DateTime fromDate, DateTime toDate, int limit)
        {
            var dateTable = DrinkDAL.Instance.GetDrinkAnalytis(fromDate, toDate, limit);
            List<DrinkAnalyticsItem> drinkAnalyticsItems = new List<DrinkAnalyticsItem>();

            foreach (DataRow row in dateTable.Rows)
            {
                drinkAnalyticsItems.Add(MapToDrinkAnalyticsItem(row));
            }

            return drinkAnalyticsItems;
        }

        public DrinkAnalyticsItem MapToDrinkAnalyticsItem(DataRow row)
        {
            return new DrinkAnalyticsItem
            {
                Name = row["NameDrink"].ToString(),
                Quantity = Convert.ToInt32(row["QuantityDrink"])
            };
        }
    }
}
