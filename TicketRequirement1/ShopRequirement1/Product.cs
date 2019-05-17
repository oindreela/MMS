using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRequirement1
{
    class Product
    {
        string  _name;
        string _productCode;
        string _brandName;
        int _stockLeft;
        double _price;
        DateTime _expiryDate;

        public string Name { get { return _name; } set { _name = value; } }
        public string ProductCode { get { return _productCode; } set { _productCode = value; } }
        public string BrandName { get { return _brandName; } set { _brandName = value; } }
        public int StockLeft { get { return _stockLeft; } set { _stockLeft = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public DateTime ExpiryDate { get { return _expiryDate; } set { _expiryDate = value; } }

        public Product() { }
        public Product(string name, string productCode, string brandName, int stockLeft, double price, DateTime expiryDate)
        {
            _name = name;
            _productCode = productCode;
            _brandName = brandName;
            _stockLeft = stockLeft;
            _price = price;
            _expiryDate = expiryDate;
        }

        public override string ToString()
        {
            return string.Format("Name:{0}\nProduct Code:{1}\nBrand Name:{2}\nStock Left:{3}\nPrice:{4}\nExpiry Date:{5}", Name, ProductCode, BrandName, StockLeft, Price, ExpiryDate);
        }

        public override bool Equals(object obj)
        {
            Product p = (Product)obj;
            if (this.Name.ToLower() == p.Name.ToLower() && this.ProductCode.Equals(p.ProductCode))
                return true;
            else
                return false;
        }



    }
}
