using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjectClasses
{
    public class ProductStatisticsManager
    {
        DBMediatorProductStatistics dbMediator;
        Dictionary<Product, int> tenMostSoldProductsQuantity;
        Dictionary<Product, double> tenMostSoldProductsProfit;
        public ProductStatisticsManager(DatabaseType databaseType)
        {
            dbMediator = new DBMediatorProductStatistics(databaseType);
        }

        public Dictionary<Product, int> GetTenMostSoldProductsQuantity()
        {
            tenMostSoldProductsQuantity = dbMediator.GetTenMostSoldProductsQuantity();
            return tenMostSoldProductsQuantity;
        }
        public Dictionary<Product, double> GetTenMostSoldProductsProfit()
        {
            tenMostSoldProductsProfit = dbMediator.GetTenMostSoldProductsProfit();
            return tenMostSoldProductsProfit;
        }


    }
}
