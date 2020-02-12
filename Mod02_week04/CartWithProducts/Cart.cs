using System;
using System.Collections.Generic;
using System.Text;

namespace CartWithProducts
{
    public class Cart : IGeneralItem
    {
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        //public Cart(ProductType pType, string name)
        //{
        //    this.ProductType = pType;
        //    this.Name = name;
        //}
    }
}
