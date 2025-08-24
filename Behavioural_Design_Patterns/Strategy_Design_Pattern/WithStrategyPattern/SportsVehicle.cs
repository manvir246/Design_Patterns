namespace WithStrategyPattern
{
    class SportsVehicle: Vehicle
    {
        public SportsVehicle() : base(new SpecialDriveStrategy())
        {
            
        }
    }
}