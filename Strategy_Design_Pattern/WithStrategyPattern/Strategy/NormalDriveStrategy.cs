namespace WithStrategyPattern
{
    class NormalDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Driving Normally");
        }
    }
}