using Decorator.Drinks;
namespace Decorator.Decorators
{
    class Marshmellow:DecoratorBase
    {
        private DrinksBase _drinksBase;
        public Marshmellow(DrinksBase drinksBase)
        {
            _drinksBase = drinksBase;
            Description = drinksBase.getDescription() + " with marshmellow";
        }
        public override double GetCost()
        {
            return _drinksBase.GetCost() + 20;
        }

    }
}
