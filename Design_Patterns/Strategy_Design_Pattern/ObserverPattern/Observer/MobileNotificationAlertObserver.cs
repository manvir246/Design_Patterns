namespace ObserverPattern
{
    public class MobileNotificationAlertObserver: INotificationAlertObserver
    {
        public void Update()
        {
            Console.WriteLine("Iphone stock is back");
        }
    }   
}