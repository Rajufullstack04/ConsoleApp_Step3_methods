using System;

namespace VehicleSystem
{
    /// <summary>
    /// A basic car
    /// </summary>
    public class Car
    {
        public string Model { get; set; }

        /// <summary>
        /// Drive method is a void method
        /// </summary>
        public void Drive()
        {
            Console.WriteLine($"The {Model} car is driving.");
        }
    }

    // Extension methods must be in a static class
    public static class CarExtensions
    {
        /// <summary>
        /// Extension method to add music system functionality
        /// </summary>
        public static void PlayMusic(this Car myCar)
        {
            Console.WriteLine($"The {myCar.Model} car is playing music 🎵.");
        }

        /// <summary>
        /// Extension method to enable GPS navigation
        /// </summary>
        public static void EnableGPS(this Car myCar, string destination)
        {
            Console.WriteLine($"The {myCar.Model} car is navigating to {destination} using GPS.");
        }
    }
    
    class Program
    {
        public static void Main()
        {
            Car car = new Car() { Model = "Tesla Model 3" };
            car.Drive();              // Normal method
            car.PlayMusic();          // Extension method
            car.EnableGPS("Airport"); // Extension method with parameter
        }
    }
}