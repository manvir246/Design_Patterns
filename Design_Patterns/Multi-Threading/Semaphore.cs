namespace Concurrency
{
    class SemaPhor
    {
        int capacity;
        int availableCapacity;
        readonly object _mutex = new object();
        public SemaPhor(int capacity)
        {
            this.capacity = capacity;
            availableCapacity = capacity;
        }

        public void Wait()
        {
            lock (_mutex)
            {
                while (availableCapacity == 0) Monitor.Wait(_mutex);
                availableCapacity--;
            }
        }
        public void Signal()
        {
            lock (_mutex)
            {
                if (availableCapacity < capacity)
                {
                    availableCapacity++;
                    Monitor.PulseAll(_mutex);
                }
            }
        }
    }
}
