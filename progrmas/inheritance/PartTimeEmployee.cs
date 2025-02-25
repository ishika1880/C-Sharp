using System;
namespace ConsoleApp1{
    public class PartTimeEmployee: Employee{
        private double HourlySalary;

        public PartTimeEmployee(String name, int id, double salary):base(name, id){
            HourlySalary1 = salary;
        }

        public double HourlySalary1 { get => HourlySalary; set => HourlySalary = value; }

        public void ShowSalary(){
            Console.WriteLine($"Full-Time Employee {Name1} has salary: {HourlySalary}");
        }
    }
}