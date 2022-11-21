using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WeekTow._06_Indexers
{
    public class Employee
    {
        //Declare the properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        //Initialize the properties through constructor
        public Employee(int ID, string Name, string Job, int Salary, string Location,
                        string Department, string Gender)
        {
            this.ID = ID;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
            this.Location = Location;
            this.Department = Department;
            this.Gender = Gender;
        }

        public object this[int index]
        {
            //The get accessor is used for returning a value
            get
            {
                if (index == 0)
                    return ID;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Location;
                else if (index == 5)
                    return Department;
                else if (index == 6)
                    return Gender;
                else
                    return null;
            }

            // The set accessor is used to assigning a value
            set
            {
                if (index == 0)
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
                else if (index == 4)
                    Location = value.ToString();
                else if (index == 5)
                    Department = value.ToString();
                else if (index == 6)
                    Gender = value.ToString();
            }
        }

       
    
    }

    //Let’s try to create an instance of the Employee class
    //and let’s try to consume the employee object like an array.
    //Let’s create another class with the main method
    //as shown below where I try to access the Employee data using index positions.



    class Program
    {
        static void Main(string[] args)
        {
            //Creating the Employee instance
            Employee emp = new Employee(101, "Kamran", "BSSE", 10000, "Faisalabad", "IT", "Male");
            //Accessing Employee Properties using Indexers i.e. using Index positions
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);
            Console.WriteLine("Location = " + emp[4]);
            Console.WriteLine("Department = " + emp[5]);
            Console.WriteLine("Gender = " + emp[6]);

            Console.ReadLine();
        }
    }


}
