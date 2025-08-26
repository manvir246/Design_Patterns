using ObserverPattern;
using DecoratorPattern;
namespace WithStrategyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Strategy Pattern: Start
            // Vehicle vehicle = new NormalVehicle();
            // vehicle.Drive();

            // Vehicle vehicle1 = new SportsVehicle();
            // vehicle1.Drive();
            // Ends

            // Observer pattern: Start
            IphoneObeservable iphoneObeservable = new IphoneObeservable();

            INotificationAlertObserver subscriber1 = new MobileNotificationAlertObserver();
            INotificationAlertObserver subscriber2 = new EmailNotificationAlertObserver("manvir@gmail.com", iphoneObeservable);
            INotificationAlertObserver subscriber3 = new EmailNotificationAlertObserver("sray@gmail.com", iphoneObeservable);

            iphoneObeservable.Add(subscriber1);
            iphoneObeservable.Add(subscriber2);
            iphoneObeservable.Add(subscriber3);

            iphoneObeservable.SetStock(2);
            // Ends

            // Decorator Patterns: Starts
            BasePizza pizza = new MargheritaPizza(new MushroomPizza(new CheesePizza()));
            Console.WriteLine(pizza.Cost());
            // Ends
        }
    }
}