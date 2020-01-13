using Decorator.Drinks;
using System;
using System.Collections.Generic;
namespace Decorator.People
{
    public class Vegan
    { 
        public Vegan(string name)
        {
            
            this.name = name;
            drinksBases = new List<DrinksBase>();
        }
        public string name;
        public List<DrinksBase> drinksBases= new List<DrinksBase>();
        public void PrintPeople()
        {
            Console.WriteLine("name: {0}", name);
            foreach (var drink in drinksBases)
            {
                Console.WriteLine("Drink: {0} \nPrice: {1}",
                drink.getDescription(), drink.GetCost());
            }

        }
        public void AddDrink(DrinksBase amm)
        {
            drinksBases.Add(amm);
        }

    }
}
