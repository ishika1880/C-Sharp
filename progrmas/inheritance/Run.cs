using System;
namespace ConsoleApp1
{
    public class Run
    {
        public static void Execute()
        {
            FullTimeEmployee ftEmployee = new FullTimeEmployee("Ishi", 101, 60000);
            ftEmployee.Display();
            ftEmployee.ShowSalary();

            Console.WriteLine(); // Line Break

            PartTimeEmployee ptEmployee = new PartTimeEmployee("Ivy", 102, 500);
            ptEmployee.Display();
            ptEmployee.ShowSalary();
        }
    }
}
