using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class SoldProduct
    {
        private Product product;
        private int quantity;
        private decimal price;

        public decimal Price
        {
            get { return price; }
        }
        public int Quantity
        {
            get { return quantity; }
        }

        public Product Product
        {
            get { return product; }
        }
        public SoldProduct(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = product.SalePrice*quantity;
        }

        public void IncreseQuanity(int quantity)
        {
            this.quantity += quantity;
            this.price = this.quantity * product.SalePrice;
        }
        public void DecreaseQuanity()
        {
            if (quantity>=0)
            {
                this.quantity --;
            }
            this.price = this.quantity * product.SalePrice;
        }
        public override string ToString()
        {
            return $"{quantity}                    {product.Brand}\t{product.Model}";
        }
    }
}