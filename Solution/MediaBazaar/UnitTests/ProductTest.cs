using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectClasses;

namespace UnitTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptyBrand()
        {
            new Product(0, "", "test", "test", "test", "test", 2, 4, 5, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptyType()
        {
            new Product(0, "test", "", "test", "test", "test", 2, 4, 5, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptyModel()
        {
            new Product(0, "test", "test", "", "test", "test", 2, 4, 5, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptyDestription()
        {
            new Product(0, "test", "test", "test", "", "test", 2, 4, 5, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptyBarcode()
        {
            new Product(0, "test", "test", "test", "test", "", 2, 4, 5, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ZeroCostPrice()
        {
            new Product(0, "test", "test", "test", "test", "test", 0, 4, 5, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ZeroSalesPrice()
        {
            new Product(0, "test", "test", "test", "test", "test", 2, 0, 5, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void MinusAmountInStore()
        {
            new Product(0, "test", "test", "test", "test", "test", 2, 4, -1, 6, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ZeroAmountInWarehouse()
        {
            new Product(0, "test", "test", "test", "test", "test", 2, 4, 5, 0, 2, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ZeroMinimumAmountInStore()
        {
            new Product(0, "test", "test", "test", "test", "test", 2, 4, 5, 6, 0, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptySupplierPhoneNumber()
        {
            new Product(0, "test", "test", "test", "test", "test", 2, 4, 5, 6, 6, "", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptySupplierEmail()
        {
            new Product(0, "test", "test", "test", "test", "test", 2, 4, 5, 6, 6, "56789", "");
        }

        [TestMethod]
        [ExpectedException(typeof(IncorrectPricingException))]
        public void CostPriceBiggerThanSalePrice()
        {
            new Product(0, "test", "test", "test", "test", "test", 5, 4, 5, 6, 6, "56789", "test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddProductError()
        {
            ProductManager product = new ProductManager(DatabaseType.TEST);
            product.AddProductToDB(new Product(0, "test", "test", "test", "test", "test", 3, 5, 4, 6, 3, "23475372", "test"));
            product.AddProductToDB(new Product(0, "test", "test", "test", "test", "test", 3, 5, 4, 6, 3, "23475372", "test"));
        }

        [TestMethod]
        public void DeleteError()
        {
            ProductManager product = new ProductManager(DatabaseType.TEST);
            Assert.IsFalse(product.DeleteAProduct(0));

        }

        [TestMethod]
        public void CheckBarcodeError()
        {
            ProductManager product = new ProductManager(DatabaseType.TEST);
            Assert.IsNull(product.GetProductByBarcode("0"));

        }

        [TestMethod]
        public void GetNameFromToStringError()
        {
            ProductManager product = new ProductManager(DatabaseType.TEST);
            Assert.IsNull(product.GetNameFromToString("test"));
        }
    }
}
