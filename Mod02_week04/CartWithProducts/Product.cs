using System;
using System.Collections.Generic;
using System.Text;

namespace CartWithProducts
{
    public class Product : IGeneralItem
    {
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //public Product(ProductType pType, string name,double price)
        //{
        //    this.Name = name;
        //    this.ProductType = pType;
        //    this.Price = price;
        //}
    }
}
