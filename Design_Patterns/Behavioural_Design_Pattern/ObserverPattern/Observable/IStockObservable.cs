namespace ObserverPattern
{
    public interface IStockObservable
    {
        public void Add(INotificationAlertObserver notificationAlertObserver);
        public void Remove(INotificationAlertObserver notificationAlertObserver);
        public void NotifySubscribers();
        public void SetStock(int newStock);
        public int GetStock();
    }
}