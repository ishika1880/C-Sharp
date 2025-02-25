using System;
namespace ConsoleApp1{
    public class FullTimeEmployee: Employee{
        private double Salary;

        public FullTimeEmployee(String name, int id, double salary):base(name, id){
            Salary1 = salary;
        }

        public double Salary1 { get => Salary; set => Salary = value; }

        public void ShowSalary(){
            Console.WriteLine($"Full-Time Employee {Name1} has salary: {Salary}");
        }
    }
}