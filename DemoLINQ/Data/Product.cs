using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ.Data
{
    class Product : IComparable<Product>
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public int CompareTo(Product? other)
        {
            if (other is null) return 1;
            return this.UnitPrice.CompareTo(other.UnitPrice);
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   ProductID == product.ProductID &&
                   ProductName == product.ProductName &&
                   Category == product.Category &&
                   UnitPrice == product.UnitPrice &&
                   UnitsInStock == product.UnitsInStock;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProductID, ProductName, Category, UnitPrice, UnitsInStock);
        }

        public override string ToString()
            => $"ProductID:{ProductID},ProductName:{ProductName},Category{Category},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";

    }
}
