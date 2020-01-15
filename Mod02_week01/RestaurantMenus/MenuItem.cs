using System;

namespace RestaurantMenus
{
      enum FoodIngredients
    {
        bread=0,
        cheese=1,
        mustar=2
    }
     abstract class MenuItem
    {
        private int itemId { get; set; }
        public   decimal pitemPice { get; set; }
    }
    class Burger : MenuItem, IFastFood
    {
       public string FoodIngredients { get; set; }
        public void eatMe()
        {

        }

    }
     class VegBurger : Burger
    {

    }
     class ChickenBurger: Burger
    {

    }

     class Drink : MenuItem, IDrink
    {

    }
     class ColdDrink : Drink
    {

    }
     class HotDrink : Drink
    {

    }
}
