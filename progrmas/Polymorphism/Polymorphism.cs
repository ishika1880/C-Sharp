using System;
namespace ConsoleApp1{
    public class Polymorphism{
        public Polymorphism(){
        }
        public void area(int a){
            Console.WriteLine($"Area of square is: {a*a}");
        }
        public void area(int l, int b){
            Console.WriteLine($"Area of Rectangle is: {l*b}");
        }

        public void area(double r){
            Console.WriteLine($"Area of Circle is: {2*3.14*r}");
        }
    }
}