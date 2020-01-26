using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenus
{
    public class Order
    {
        List<IDrink> drinks = new List<IDrink>();

        List<IFastFood> foods = new List<IFastFood>();
        
        internal void AddFood(IFastFood food)
        {
            foods.Add(food);
        }
        internal void AddDrink(IDrink drink)
        {
            drinks.Add(drink);
        }
    }

}
