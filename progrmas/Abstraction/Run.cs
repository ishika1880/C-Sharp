using System;

namespace ConsoleApp1
{
    public class RunAbstraction
    {
        public static void Run()
        {
            Car myCar = new Car("Toyota", 180, 4);
            Bike myBike = new Bike("Yamaha", 220, "Sports");

            myCar.ShowDetails();
            myBike.ShowDetails();
        }
    }
}
