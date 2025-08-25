namespace WithStrategyPattern
{
    class NormalVehicle: Vehicle
    {
        public NormalVehicle() : base(new NormalDriveStrategy())
        {
        }
    }
}