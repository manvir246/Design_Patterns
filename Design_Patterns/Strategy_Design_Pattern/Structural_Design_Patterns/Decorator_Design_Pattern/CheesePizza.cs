namespace DecoratorPattern
{
    class CheesePizza: BasePizza
    {
        BasePizza basePizza = null;
        public CheesePizza(BasePizza basePizza)
        {
            this.basePizza = basePizza;
        }
        public CheesePizza(){}
        public override int Cost()
        {
            return 130 + (basePizza?.Cost() ?? 0);
        }
    }
}