namespace Decorator.Drinks
{
    class Coffee: DrinksBase
    {
        public Coffee()
        {
            Description = "Just coffee and water";
        }

       
        public override double GetCost()
        {
            return 55;
        }
    }
}
