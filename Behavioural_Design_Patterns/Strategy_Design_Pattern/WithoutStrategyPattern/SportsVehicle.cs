namespace WithoutStrategyPattern
{
    class SportsVehicle: Vehicle
    {
        public override void Drive()
        {
            int initialSpeed = 40;
            initialSpeed += 10;
        }
    }
}