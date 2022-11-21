using System;
using System.Collections.Generic;
namespace GenericListCollectionDemo
{
    class Program
    {
        static void Main()
        {
            //Creating a Generic List of string type to store string elements
            List<string> countries = new List<string>();

            //Adding String Elements to the Generic List using the Add Method
            countries.Add("INDIA");
            countries.Add("USA");

            //The following Two Statements will give compile time error as element is not string type
            //countries.Add(100);
            //countries.Add(true);

            //Creating Another Generic List Collection of String Type
            List<string> newCountries = new List<string>();

            //Adding Elements using Add Method
            newCountries.Add("JAPAN");
            newCountries.Add("UK");

            //Adding the newCountries collection into countries collection using AddRange Method
            countries.AddRange(newCountries);

            //Accessing Generic List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

            //Accessing Generic List Elements using For Loop
            Console.WriteLine("\nAccessing Generic List using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                var element = countries[i];
                Console.WriteLine(element);
            }

            //Accessing List Elements by using the Integral Index Position
            Console.WriteLine("\nAccessing Individual List Element by Index Position");
            Console.WriteLine($"First Element: {countries[0]}");
            Console.WriteLine($"Second Element: {countries[1]}");
            Console.WriteLine($"Third Element: {countries[2]}");
            Console.WriteLine($"Fourth Element: {countries[3]}");





            // Working with the Classes
            // Create Employee Objects
            Employee emp1 = new Employee() { ID = 101, Name = "Pra", Gender = "Male", Salary = 5000 };
            Employee emp2 = new Employee() { ID = 102, Name = "Pri", Gender = "Female", Salary = 7000 };
            Employee emp3 = new Employee() { ID = 103, Name = "Ali", Gender = "Male", Salary = 5500 };

            // Create a Generic List of type Employee
            List<Employee> listEmployees = new List<Employee>();
            //Adding Employees to the listEmployees collection using Add Method
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
         
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