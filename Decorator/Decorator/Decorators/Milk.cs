using Decorator.Drinks;
namespace Decorator.Decorators
{
    class Milk:DecoratorBase
    {
        private DrinksBase _drinksBase;
        public Milk(DrinksBase drinksBase,bool vegan)
        {
            _drinksBase = drinksBase;
            if(vegan==true)
            { 
                Description = drinksBase.getDescription() + " with coconut milk";
            }
            else
            {
                Description = drinksBase.getDescription() + " with milk";
            }
        }
        public override double GetCost()
        {
            return _drinksBase.GetCost() + 100;
        }
    }
}
