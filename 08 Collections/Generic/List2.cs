using System;
using System.Collections.Generic;
using System.Linq;
namespace ListCollectionDemo
{
    public class Program
    {
        public static void Main()
        {
            //Creating a list of type Employee
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { ID = 101, Name = "mosh", Gender = "Male", Salary = 5000 },
                new Employee() { ID = 102, Name = "ali", Gender = "Female", Salary = 7000 },
                new Employee() { ID = 103, Name = "shahid", Gender = "Male", Salary = 5500 },
                new Employee() { ID = 104, Name = "hina", Gender = "Male", Salary = 6500 },
                new Employee() { ID = 105, Name = "ali", Gender = "Female", Salary = 6500 }
            };

            Console.WriteLine("Employees Before Sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

            //Sorting Employee using Linq OrderBy Method
            listEmployees = listEmployees.OrderBy(x => x.Name).ToList();
            Console.WriteLine("\nEmployees After Sorting using Linq");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name},  Gender = {employee.Gender}, Salary = {employee.Salary}");
            }

            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}