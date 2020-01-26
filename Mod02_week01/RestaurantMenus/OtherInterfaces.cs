using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenus
{
    interface IOrder
    {
        List<IDrink> drinks { get; set; }

        List<IFastFood> foods { get; set; }

        void AddFood(IFastFood food);

        void AddDrink(IDrink drink);
        
    }
}
