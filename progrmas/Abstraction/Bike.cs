using System;
namespace ConsoleApp1
{
    public class Bike : Vehicle
    {
        private string type;
        public string Type { get => type; set => type = value; }

        public Bike(string brand, int speed, string type) : base(brand, speed)
        {
            Type = type;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Bike Brand: {Brand}, Speed: {Speed} km/h, Type: {Type}");
        }
    }
}
