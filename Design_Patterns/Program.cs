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

            // Example: 02
            // var cart = new ShoppingCart();

            // cart.SetPaymentStrategy(new CreditCardPayment());
            // cart.Checkout(100.0); // Paid 100 using Credit Card.

            // cart.SetPaymentStrategy(new PayPalPayment());
            // cart.Checkout(200.0); // Paid 200 using PayPal.
            // At runtime, we easily changed the functionality (creditCard Payment object to PayPal Payment object).

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

            #region Tic-Tac-Toe Game

            // Game tictactoe = new Game();
            // tictactoe.StartGame();

            #endregion
        }
    }
}