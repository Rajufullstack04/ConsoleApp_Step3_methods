using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASyncOtherExmapleContainer
{
    class Coffeshop
    {
        public static async Task CallingFreindPeterAtCoffeshop()
        {
            Console.WriteLine("Calling Peter freind");
            await Task.Delay(5000);
            Console.WriteLine("Peter - Freind came");
        }

        public static async Task CallingFreindJohnAtCoffeshop()
        {
            Console.WriteLine("Calling John freind");
            await Task.Delay(10000);
            Console.WriteLine("Freind John came");
        }

        public static async Task CallingFreindRamAtCoffeshop()
        {
            Console.WriteLine("Calling Ram freind");
            await Task.Delay(8000);
            Console.WriteLine("Freind Ram came");
        }

    }

    class Program
    {
        public static async Task Main()
        {
            //await Coffeshop.CallingFreindPeterAtCoffeshop();  // Correct the way you are calling ayync method thats correct.

            //Coffeshop.CallingFreindJohnAtCoffeshop();

            Task callingPeter = Coffeshop.CallingFreindPeterAtCoffeshop();
            Task callingJohn = Coffeshop.CallingFreindJohnAtCoffeshop();
            Task callingRam = Coffeshop.CallingFreindRamAtCoffeshop();

            await Task.WhenAll(callingPeter, callingJohn, callingRam);

        }
    }



    //Task:Cokking , Task:chatfreind , Task:lisitnmusic -- concurenlty i can do that 


}