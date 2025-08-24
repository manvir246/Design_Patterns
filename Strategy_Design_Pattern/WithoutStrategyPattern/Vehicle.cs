namespace WithoutStrategyPattern
{
    class Vehicle
    {
        public virtual void Drive()
        {
            int initialSpeed = 10;
            Console.WriteLine(initialSpeed);
            Console.WriteLine("Driving Normally");
        }

        public void Display()
        {
            Console.WriteLine("It is a vehicle");
        }
    }
}