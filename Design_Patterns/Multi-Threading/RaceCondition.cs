namespace Concurrency
{
    class RaceCondition
    {
        int count = 0;
        void Worker()
        {
            for (int i = 1; i <= 100; i++)
            {
                count++;
                Thread.Sleep(2);
            }
        }
        public void Run()
        {
            new Thread(Worker).Start();
            new Thread(Worker).Start();

            Console.WriteLine("The shared memory count is: " + count);
        }
    }
}