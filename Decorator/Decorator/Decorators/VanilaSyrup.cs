using Decorator.Drinks;
namespace Decorator.Decorators
{
    class VanilaSyrup:DecoratorBase
    {
        private DrinksBase _drinksBase;
        public VanilaSyrup(DrinksBase drinksBase)
        {
            _drinksBase = drinksBase;
            Description = drinksBase.getDescription() + " with vanilla syrup";
        }
        public override double GetCost()
        {
            return _drinksBase.GetCost() + 40;
        }

    }
}
