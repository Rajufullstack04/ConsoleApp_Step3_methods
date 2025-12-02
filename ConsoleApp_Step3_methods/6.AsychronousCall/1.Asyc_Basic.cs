using System;
using System.Threading.Tasks;


namespace AsyncContainer
{
    class workOuts
    {
        public static async Task Method1()
        {

            Console.WriteLine("Waiting in hall");
            await Task.Delay(10000); //  ------ Task it is some time
            Console.WriteLine("Hello world..");
        }

        public static void Method2()
        {
            Console.WriteLine("Again Hello world");
        }

        static void Main()
        {
            workOuts.Method1();
            workOuts.Method2();

            Console.ReadLine();
        }



    }
}