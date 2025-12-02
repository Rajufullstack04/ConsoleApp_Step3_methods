using System;


namespace PhoneSystem
{
    /// <summary>
    /// A basic smartphone
    /// </summary>
    public class Smartphone
    {
        public string Brand { get; set; }
        /// <summary>
        ///  Make a call is a void method 
        /// </summary>
        /// <param name="number"></param>
        public void MakeCallApp(string number)
        {
            Console.WriteLine($"Calling {number} from {Brand} smartphone.");
        }
    }

    //FitnessApp

    // Note: static class contains only static members

    public static class SmartphoneExtensions
    {
        public static void TrackFitnessApp(this Smartphone myPhone)
        {
            Console.WriteLine($"The {myPhone.Brand} smartphone is tracking fitness now!");
        }
    }


    class Program
    {
        public static void Main()
        {
            Smartphone phone = new Smartphone() { Brand = "Pixel" };
            phone.MakeCallApp("12345678");
            phone.TrackFitnessApp();
        }
    }





}