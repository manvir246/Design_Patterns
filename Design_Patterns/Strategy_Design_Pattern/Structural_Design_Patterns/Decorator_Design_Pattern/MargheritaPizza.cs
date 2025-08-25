namespace DecoratorPattern
{
    class MargheritaPizza : BasePizza
    {
        BasePizza basePizza;
        public MargheritaPizza(BasePizza basePizza) {
            this.basePizza = basePizza;
        }
        public MargheritaPizza(){ }
        public override int Cost()
        {
            return 100 + (basePizza?.Cost() ?? 0);
        }
    }
}