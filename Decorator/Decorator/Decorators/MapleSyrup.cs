using Decorator.Drinks;

namespace Decorator.Decorators
{
    class MapleSyrup:DecoratorBase
    {
        private DrinksBase _drinksBase;
        public MapleSyrup(DrinksBase drinksBase)
        {
            _drinksBase = drinksBase;
            Description = drinksBase.getDescription() + " with maple syrup";
        }
        public override double GetCost()
        {
            return _drinksBase.GetCost() + 40;
        }
    }
}
