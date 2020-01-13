namespace Decorator.Drinks
{
    public abstract class DrinksBase 
    {
        protected string Description = "";
        protected bool vegan=false;
        public string getDescription()
        {
            return Description;
        }

        public bool getVegan()
        {
            return vegan;
        }
        public abstract double GetCost();
    }
}
