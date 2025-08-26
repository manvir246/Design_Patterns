namespace WithStrategyPattern
{
    class Vehicle
    {
        private IDriveStrategy driveStrategy;
        public Vehicle(IDriveStrategy driveStrategy)
        {
            this.driveStrategy = driveStrategy;
        }
        public void Drive()
        {
            driveStrategy.Drive();
        }
    }
}