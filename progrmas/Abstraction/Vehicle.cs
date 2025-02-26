using System;
namespace ConsoleApp1
{
    public abstract class Vehicle
    {
        private string brand;
        private int speed;

        public string Brand { get => brand; set => brand = value; }
        public int Speed { get => speed; set => speed = value; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public abstract void ShowDetails();
    }
}