using Decorator.Drinks;
using System;
using System.Collections.Generic;
namespace Decorator.People
{
    public class NotVegan
    {
        public NotVegan(string name)
        {

            this.name = name;
            drinkBases = new List<DrinksBase>();
        }
        public string name;
        public List<DrinksBase> drinkBases;
        public void PrintPeople()
        {
            Console.WriteLine("name: {0}", name);
            foreach (var drink in drinkBases)
            {
                Console.WriteLine("Drink: {0} \nPrice: {1}",
                drink.getDescription(), drink.GetCost());
            }

        }
        public void AddDrink(DrinksBase amm)
        {
            drinkBases.Add(amm);
        }


    }
}
