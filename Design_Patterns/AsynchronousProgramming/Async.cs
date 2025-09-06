using System.Threading.Tasks;

namespace Async
{
    class Prog
    {
        public async Task<string> OrderPizzaAsync()
        {
            Console.WriteLine("Step 1: Taking order");
            Console.WriteLine("Step 2: Preparing dough");

            await Task.Delay(2000); // simulate async oven
            Console.WriteLine("Step 3: Pizza is ready");

            return "";
        }
    }
}