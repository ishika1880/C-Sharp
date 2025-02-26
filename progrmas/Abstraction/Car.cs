using System;
namespace ConsoleApp1
{
    public class Car : Vehicle
    {
        private int doors;
        public int Doors { get => doors; set => doors = value; }

        public Car(string brand, int speed, int doors) : base(brand, speed)
        {
            Doors = doors;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Car Brand: {Brand}, Speed: {Speed} km/h, Doors: {Doors}");
        }
    }
}