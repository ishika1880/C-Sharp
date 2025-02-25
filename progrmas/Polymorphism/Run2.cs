using System;

namespace ConsoleApp1
{
    public class Run2
    {
        public static void run2()
        {
            Polymorphism poly = new Polymorphism();

            Console.WriteLine("Press 1 for calculating the area of a square");
            Console.WriteLine("Press 2 for calculating the area of a rectangle");
            Console.WriteLine("Press 3 for calculating the area of a circle");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter side length of square: ");
                    int side = Convert.ToInt32(Console.ReadLine());
                    poly.area(side);
                    break;

                case 2:
                    Console.Write("Enter length of rectangle: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter breadth of rectangle: ");
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    poly.area(length, breadth);
                    break;

                case 3:
                    Console.Write("Enter radius of circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    poly.area(radius);
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        }
    }
}
