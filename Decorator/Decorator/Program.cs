using System;
using Decorator.Drinks;
using Decorator.Decorators;
using Decorator.People;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksBase MyCoffee = new Coffee();
            DrinksBase MyCacaoNotV = new Cacao(false);
            DrinksBase MyCacaoV = new Cacao(true);
            DrinksBase MyTea = new Tea();
            PrintDrink(MyCoffee);
            PrintDrink(MyCacaoNotV);
            PrintDrink(MyCacaoV);
            Console.WriteLine();
            DrinksBase SyrupCoffee = new VanilaSyrup(new Coffee());
            DrinksBase VeganCoffee = new Milk(new Coffee(),true);
            DrinksBase NotVeganCacao = new MapleSyrup(new Marshmellow(new Cacao(false)));

            PrintDrink(SyrupCoffee);
            PrintDrink(VeganCoffee);
            PrintDrink(NotVeganCacao);
            Console.WriteLine();

            Vegan v = new Vegan("Mariya");
            v.AddDrink(new Milk(new Marshmellow(new Coffee()),true));
            v.AddDrink(MyTea);
    
            NotVegan notv = new NotVegan("Daria");
            notv.AddDrink(new Milk(new MapleSyrup(new Coffee()),false));
            v.PrintPeople();
            Console.WriteLine();
            notv.PrintPeople();
            Console.ReadKey();
        }
        static void PrintDrink(DrinksBase  ammuntion)
        {
            Console.WriteLine("Drink: {0} \nPrice: {1}",
               ammuntion.getDescription(), ammuntion.GetCost());
        }
    }
}
