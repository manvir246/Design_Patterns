using ObserverPattern;
using DecoratorPattern;
using FactoryPattern;
namespace WithStrategyPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Strategy Pattern

            // Vehicle vehicle = new NormalVehicle();
            // vehicle.Drive();

            // Vehicle vehicle1 = new SportsVehicle();
            // vehicle1.Drive();

            #endregion

            #region Observer pattern

            // IphoneObeservable iphoneObeservable = new IphoneObeservable();

            // INotificationAlertObserver subscriber1 = new MobileNotificationAlertObserver();
            // INotificationAlertObserver subscriber2 = new EmailNotificationAlertObserver("manvir@gmail.com", iphoneObeservable);
            // INotificationAlertObserver subscriber3 = new EmailNotificationAlertObserver("sray@gmail.com", iphoneObeservable);

            // iphoneObeservable.Add(subscriber1);
            // iphoneObeservable.Add(subscriber2);
            // iphoneObeservable.Add(subscriber3);

            // iphoneObeservable.SetStock(2);

            #endregion

            #region Decorator Patterns

            // BasePizza pizza = new MargheritaPizza(new MushroomPizza(new CheesePizza()));
            // Console.WriteLine(pizza.Cost());

            #endregion

            #region Factory Pattern

            // IShape shape = new ShapeFactory().GetShape("Circle");
            // shape.Draw();

            #endregion
        }
    }
}