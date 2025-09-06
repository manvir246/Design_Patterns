using ObserverPattern;
using DecoratorPattern;
using FactoryPattern;
using Concurrency;
using Async;
using System.Threading.Tasks;
namespace WithStrategyPattern
{
    class Program
    {
        static SemaPhor semaPhore = new SemaPhor(2);

        public static void Worker(object id)
        {
            Console.WriteLine($"Thread: {id} is running");
            semaPhore.Wait();
            //Critical Section :: Only two threads are allowed at a time.

            Thread.Sleep(1000);
            Console.WriteLine($"Thread: {id} is in Critical Section.");

            //Leaving
            semaPhore.Signal();
            Console.WriteLine($"Thread: {id} left.");
        }

        public static async Task Main(string[] args)
        {
            #region Multi-Threading Environment Test

            // Task t = Task.Run(async () => {
            //     Console.WriteLine("Task running");
            //     await Task.Delay(2000);
            //     Console.WriteLine("Task running");
            // });
            // Console.WriteLine("Task outside running");
            // Console.WriteLine("Task outside running");

    
            // Prog prog = new Prog();
            // Task t1 = prog.OrderPizzaAsync();
            // Task t2 = prog.OrderPizzaAsync();
            // Task t3 = prog.OrderPizzaAsync();
            // Task t4 = prog.OrderPizzaAsync();

            // Console.WriteLine("It is in the main method");
            // Console.WriteLine("It is in the main method");
            
            // await t1;
            // await t2;
            // await t3;
            // await t4;

            //Using thread pool
            // for (int i = 1; i <= 5; i++)
            //     ThreadPool.QueueUserWorkItem(Worker, i);

            //Using normal thread creation
            // for (int i = 1; i <= 5; i++)
            //     new Thread(Worker).Start(i);

            // RaceCondition raceCondition = new RaceCondition();
            // raceCondition.Run();

            #endregion

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