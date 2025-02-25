using System;
namespace ConsoleApp1{
    public class Employee{
        private string Name = string.Empty;
        private int EmployeeID;

        public Employee(String name, int id){
            Name1 = name;
            EmployeeID1 = id;
        }

        public string Name1 { get => Name; set => Name = value; }
        public int EmployeeID1 { get => EmployeeID; set => EmployeeID = value; }

        public void Display(){
            Console.WriteLine($"Employee ID: {EmployeeID1}, Name: {Name1}");
        }
    }
}