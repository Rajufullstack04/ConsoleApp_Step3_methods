using System;
using System.Threading.Tasks;

namespace AsynchronousCallContainer
{
    class Kitchen
    {
        /// <summary>
        /// Prepare rice by boiling it. Takes 3 seconds.
        /// </summary>
        public static async Task BoilRiceAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(3000); // Simulate 3 seconds cooking
            var end = DateTime.Now;

            Console.WriteLine($"Rice boiled in {(end - start).TotalMilliseconds} ms.");
        }

        /// <summary>
        /// Prepare vegetables by frying them. Takes 2 seconds.
        /// </summary>
        public static async Task FryVegetablesAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(2000); // Simulate 2 seconds cooking
            var end = DateTime.Now;

            Console.WriteLine($"Vegetables fried in {(end - start).TotalMilliseconds} ms.");
        }

        /// <summary>
        /// Prepare soup. Takes 4 seconds.
        /// </summary>
        public static async Task MakeSoupAsync()
        {
            var start = DateTime.Now;
            await Task.Delay(4000); // Simulate 4 seconds cooking
            var end = DateTime.Now;

            Console.WriteLine($"Soup prepared in {(end - start).TotalMilliseconds} ms.");
        }
    }

    class Chef
    {
        public static async Task CookFoodAsync()
        {
            Console.WriteLine("Cooking Food in parallel (asynchronous)...");

            var start = DateTime.Now;

            // Run all tasks concurrently
            await Task.WhenAll(
                Kitchen.BoilRiceAsync(),
                Kitchen.FryVegetablesAsync(),
                Kitchen.MakeSoupAsync()
            );

            var end = DateTime.Now;

            Console.WriteLine($"Food completed in {(end - start).TotalMilliseconds} ms.");
        }
    }

    class Program
    {
        static async Task Main()
        {
            await Chef.CookFoodAsync();
            Console.ReadLine();
        }
    }
}