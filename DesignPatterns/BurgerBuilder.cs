namespace DesignPatterns
{
    public class BurgerBuilder
    {
        private Burger burger = new();
        public BurgerBuilder AddCheese(string cheese)
        {
            burger.Cheese = cheese;
            return this;
        }
        public BurgerBuilder AddSauce(string sauce)
        {
            burger.Sauce = sauce;
            return this;
        }
        public Burger Build()
        {
            return burger;
        }
    }
}
