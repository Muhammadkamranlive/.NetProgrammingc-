using System;
namespace ConstructorDemo
{
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;
    }
    class Test
    {
        static void Main(string[] args)
        {
            //Default constuctor
            Employee e1 = new Employee();
            Console.WriteLine("Employee Id is:  " + e1.Id);
            Console.WriteLine("Employee Name is:  " + e1.Name);
            Console.WriteLine("Employee Age is:  " + e1.Age);
            Console.WriteLine("Employee Address is:  " + e1.Address);
            Console.WriteLine("Is Employee Permanent:  " + e1.IsPermanent);
            Console.ReadKey();
        }
    }



    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;

        //User Defined Default Constructor
        public Employee()
        {
            Id = 100;
            Age = 30;
            Address = "FSD";
            Name = "Kamran";
            IsPermanent = true;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);
            Console.WriteLine("Employee Age is:  " + Age);
            Console.WriteLine("Employee Address is:  " + Address);
            Console.WriteLine("Employee Name is:  " + Name);
            Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
        }
    }

    class Program
    {
        private Program()
        {
            Console.WriteLine("This is private constructor");
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Display();
            //Private constructor  to create object in same class
            Program p = new Program();
            Console.WriteLine("Main method");
            Console.ReadKey();
        }
    }

}




