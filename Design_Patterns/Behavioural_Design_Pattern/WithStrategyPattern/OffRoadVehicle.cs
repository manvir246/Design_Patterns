namespace WithStrategyPattern
{
    class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle() : base(new SpecialDriveStrategy())
        {
        }
    }
}