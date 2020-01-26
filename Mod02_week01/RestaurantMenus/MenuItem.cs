using System;
using System.Collections.Generic;

namespace RestaurantMenus
{
     
     class MenuItem
    {
        private int itemId { get; set; }
        public decimal itemPrice { get; set; }
    }
    abstract class Burger : MenuItem, IFastFood
    {
        public Burger()
        {
            this.Ingredients.Add(FoodIngredients.bread);
            this.Ingredients.Add(FoodIngredients.salt);
            this.isHeated = false;
        }
        public List<FoodIngredients> Ingredients { get; set; }
        public bool isHeated { get; set; }
        public void GoToMicrowave()
        {
            this.isHeated = true;
        }
        public void AddMustard()
        {
            this.Ingredients.Add(FoodIngredients.mustard);
        }
        public abstract void SelectBaseIngredient();
    }
    class VegBurger : Burger
    {
        public override void SelectBaseIngredient()
        {
            this.Ingredients.Add(FoodIngredients.soy);
        }
    }
    class ChickenBurger : Burger
    {
        public override void SelectBaseIngredient()
        {
            this.Ingredients.Add(FoodIngredients.chickenMeat);
        }
    }



    abstract class Drink : MenuItem, IDrink
    {
        public bool hasAcid { get; set; }
        public drinkState state { get; set; }

        public abstract void Prepare();        
    }
    class ColdDrink : Drink
    {
        public ColdDrink()
        {
            this.state = drinkState.cold;            
        }
        public override void Prepare()
        {
            Console.WriteLine("Cold Drind ready !");
        }        
    }
    class HotDrink : Drink
    {
        public HotDrink()
        {
            this.state = drinkState.hot;
            this.hasAcid = false;
        }
        public override void Prepare()
        {
            Console.WriteLine("Hot Drind ready !");
        }
    }
}
