namespace ObserverPattern
{
    public class IphoneObeservable: IStockObservable
    {
        int stock = 0;
        List<INotificationAlertObserver> subscriberList = new List<INotificationAlertObserver>();

        public void Add(INotificationAlertObserver obj)
        {
            subscriberList.Add(obj);
        }
        public void Remove(INotificationAlertObserver obj)
        {
            subscriberList.Remove(obj);
        }
        public void NotifySubscribers()
        {
            foreach (var subscriber in subscriberList)
            {
                subscriber.Update();
            }
        }
        public void SetStock(int newStock)
        {
            if (stock == 0)
            {
                NotifySubscribers();
            }
            stock += newStock;
        }
        public int GetStock()
        {
            return stock;
        }
    }
}