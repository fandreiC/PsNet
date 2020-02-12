using System;
using System.Collections.Generic;
using System.Text;

namespace CartWithProducts
{
    public interface IGeneralItem
    {
         ProductType ProductType { get; set; }
         string Name { get; set; }
    }
}
