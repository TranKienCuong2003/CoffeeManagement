using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.utils
{
    public class PriceUtils
    {
        public static decimal ToPriceNumber(string priceStr)
        {
            return Convert.ToDecimal(priceStr.Split(',')[0].Replace(".", ""));
        }

        public static string ToPriceString(decimal priceNumber) {
            CultureInfo culture = new CultureInfo("vi-VN");
            return priceNumber.ToString("c", culture);
        }

        public static string ToPercentString(decimal percentNumber)
        {
            return percentNumber.ToString() + "%";
        }
    }
}
