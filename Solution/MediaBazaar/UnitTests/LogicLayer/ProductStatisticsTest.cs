using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClasses;

namespace UnitTests.LogicLayer.Tests
{
    [TestClass()]
    public class ProductStatisticsTest
    {
        ProductStatisticsManager productStatisticsManager;

        [TestMethod()]
        public void GetTenMostSoldProductsQuantity()
        {
            productStatisticsManager = new ProductStatisticsManager(DatabaseType.TEST);
            int[] productNum = new[] { 7, 49, 50, 51, 6, 1, 2, 5, 55, 4 };
            int i = 0;
            foreach(var product in productStatisticsManager.GetTenMostSoldProductsQuantity())
            {
                Assert.AreEqual(product.Key.PNumber, productNum[i]);
                i++;
            }
        }
        [TestMethod()]
        public void GetTenMostSoldProductsProfit()
        {
            productStatisticsManager = new ProductStatisticsManager(DatabaseType.TEST);
            int[] productNum = new[] { 5,2,3,7,1,4,6,50,51,52 };
            int i = 0;
            foreach(var product in productStatisticsManager.GetTenMostSoldProductsProfit())
            {
                Assert.AreEqual(product.Key.PNumber, productNum[i]);
                i++;
            }
        }

    }
}
