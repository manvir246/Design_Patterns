namespace ObserverPattern
{
    public class EmailNotificationAlertObserver : INotificationAlertObserver
    {
        string emailId;
        IStockObservable obj;
        public EmailNotificationAlertObserver(string emailId, IStockObservable obj)
        {
            this.emailId = emailId;
            this.obj = obj;
        }
        public void Update()
        {
            SendEmail(emailId, "Email sent to : ");
            obj.GetStock(); //if we want to get some data from observable then need to pass the constructor as Ibservable
        }
        void SendEmail(string emailId, string message)
        {
            Console.WriteLine(message + emailId);
        }
    }
}