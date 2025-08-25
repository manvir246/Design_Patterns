namespace WithoutStrategyPattern
{
    class OffRoadVehicle: Vehicle
    {
        public override void Drive()
        {
            int initialSpeed = 40;
            initialSpeed += 10;
        }
    }
}