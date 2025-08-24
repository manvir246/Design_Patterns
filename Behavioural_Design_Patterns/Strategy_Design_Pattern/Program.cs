namespace WithStrategyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new NormalVehicle();
            vehicle.Drive();

            Vehicle vehicle1 = new SportsVehicle();
            vehicle1.Drive();
        }
    }
}