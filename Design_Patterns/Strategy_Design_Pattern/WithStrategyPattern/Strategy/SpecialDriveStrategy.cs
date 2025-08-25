namespace WithStrategyPattern
{
    class SpecialDriveStrategy : IDriveStrategy
    {
        public void Drive()
        {
            Console.WriteLine("Driving with fun");
        }
    }
}