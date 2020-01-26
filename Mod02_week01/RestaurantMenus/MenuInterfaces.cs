using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenus
{
    internal enum FoodIngredients
    {
        bread = 0,
        cheese = 1,
        mustard = 2,
        salt = 3,
        sugar = 4,
        chickenMeat = 5,
        beefMeat = 6,
        salat = 7,
        soy = 8
    }
    interface IFastFood
    {
        List<FoodIngredients> Ingredients { get; set; }
        bool isHeated { get; set; }
        void GoToMicrowave();
        void AddMustard();
        void SelectBaseIngredient();

    }

    enum drinkState
    {
        cold, hot, roomTemperature
    }
    interface IDrink
    {
        bool hasAcid { get; set; }
        drinkState  state { get; set; }
        void Prepare();
    }


}
