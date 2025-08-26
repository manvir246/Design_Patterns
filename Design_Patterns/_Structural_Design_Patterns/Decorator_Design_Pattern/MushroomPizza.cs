namespace DecoratorPattern
{
    class MushroomPizza: BasePizza
    {
        BasePizza basePizza;
        public MushroomPizza(BasePizza basePizza)
        {
            this.basePizza = basePizza;
        }
        public MushroomPizza(){}

        public override int Cost()
        {
            return 70 + (basePizza?.Cost() ?? 0);
        }
    }
}