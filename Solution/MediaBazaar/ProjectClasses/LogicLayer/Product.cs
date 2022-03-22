using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class Product
    {
        private int pNumber;
        private string brand;
        private string type;
        private string model;
        private string barcode;
        private string description;
        private decimal costPrice;
        private decimal salePrice;
        private int amountInStore;
        private int amountInWarehouse;
        private int minimumAmountInStore;
        private string supplierPhoneNumber;
        private string supplierEmail;

        public int PNumber { get { return this.pNumber; } }

        public string Brand { get { return this.brand; } }

        public string Type { get { return this.type; } }

        public string Model { get { return this.model; } }

        public string Description { get { return this.description; } }
        public string Barcode{ get { return this.barcode; } }

        public decimal SalePrice { get { return this.salePrice; } }

        public decimal CostPrice { get { return this.costPrice; } }

        public int AmountInStore { get { return this.amountInStore; } }

        public int AmountInWarehouse { get { return this.amountInWarehouse; } }

        public int MinimumAmountInStore { get { return this.minimumAmountInStore; } }

        public string SupplierPhoneNumber { get { return this.supplierPhoneNumber; } }

        public string SupplierEmail { get { return this.supplierEmail; } }

        public string GetName { get { return $"{this.pNumber}--{this.brand} {this.model}"; } }

        public Product(int pNumber, string brand, string type, string model, string description,string barcode, decimal costPrice,
            decimal salePrice, int amountInStore, int amountInWarehouse, int minimumAmountInStore, string supplierPhoneNumber, string supplierEmail)
        {
            if (brand == "" || type == "" || model == "" || description == "" || barcode == "" || supplierPhoneNumber == ""|| supplierEmail == "" ||
                costPrice <= 0 || salePrice <= 0 || amountInStore < 0 || amountInWarehouse <= 0 || minimumAmountInStore <=0 || supplierPhoneNumber == ""
                || supplierEmail == "")
            {
                throw new FormatException();
            }

            if (costPrice >= salePrice)
            {
                throw new IncorrectPricingException();
            }

            this.pNumber = pNumber;
            this.brand = brand;
            this.type = type;
            this.model = model;
            this.description = description;
            this.barcode = barcode;
            this.costPrice = costPrice;
            this.salePrice = salePrice;
            this.amountInStore = amountInStore;
            this.amountInWarehouse = amountInWarehouse;
            this.minimumAmountInStore = minimumAmountInStore;
            this.supplierPhoneNumber = supplierPhoneNumber;
            this.supplierEmail = supplierEmail;
        }
       
        public override string ToString()
        {
            return $"{this.brand} {this.model}.";
        }
    }
}
