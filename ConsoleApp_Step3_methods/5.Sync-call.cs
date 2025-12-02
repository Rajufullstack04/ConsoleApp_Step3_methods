using System;
using System.Threading;

namespace SynchronousCallContainar
{
    #region
    /* What is Synchrous call ?
       * A : Synchronous call means that the program will wait for the method to complete before moving on to the next line of code.
      */
    #endregion
    class Kitchen
    {
        /// <summary>
        /// Prepare rice by boling it.Now preprating rice tacking 3 seconds.
        /// </summary>
        
        public static void BoilRice()
        {
            var start = DateTime.Now;
            Thread.Sleep(3000); // Simulate 3 seconds cooking
            var end = DateTime.Now;

            //var elapsedTime = end - start;

            //Console.WriteLine($"Rice boiled in {elapsedTime.TotalMilliseconds} ms.");

            Console.WriteLine($"Rice boiled in {(end - start).TotalMilliseconds} ms.");
        }

        /// <summary>
        /// prepare vegetables by fring it. Now prepration vegetables taking 2 seconds.
        /// </summary>
        public static void FryVegetables()
        {
            var start = DateTime.Now;
            Thread.Sleep(2000); // Simulate 2 seconds cooking
            var end = DateTime.Now;

            //var elapsedTime = end - start; // 2secs
            //Console.WriteLine($"Vegetables fried in {elapsedTime.TotalMilliseconds} ms.");



            Console.WriteLine($"Vegetables fried in {(end - start).TotalMilliseconds} ms.");


            
        }

        /// <summary>
        /// prepare soup by making it. Now prepration soup taking 4 seconds.
        /// </summary>

        public static void MakeSoup()
        {
            var start = DateTime.Now;
            Thread.Sleep(4000); // Simulate 4 seconds cooking
            var end = DateTime.Now;

            Console.WriteLine($"Soup prepared in {(end - start).TotalMilliseconds} ms.");
        }
    }

    class Program
    {
        static void Main()
        {
            Chef.CookFood();
            Console.ReadLine();
        }
    }

    class Chef
    {
        public static void CookFood()
        {
            Console.WriteLine("Cooking Food step by step (synchronous)...");

            var start = DateTime.Now;

            Kitchen.BoilRice();       // 3 secs
            Kitchen.FryVegetables();  // 2 secs
            Kitchen.MakeSoup();       // 4 secs

            var end = DateTime.Now;


            Console.WriteLine($"Food completed in {(end - start).TotalMilliseconds} ms.");
        }
    }

  
}