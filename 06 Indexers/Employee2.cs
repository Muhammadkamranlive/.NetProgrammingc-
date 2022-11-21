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

        public object this[string Name]
        {
            //The get accessor is used for returning a value
            get
            {
                if (Name.ToUpper() == "ID")
                    return ID;
                else if (Name.ToUpper() == "NAME")
                    return Name;
                else if (Name.ToUpper() == "JOB")
                    return Job;
                else if (Name.ToUpper() == "SALARY")
                    return Salary;
                else if (Name.ToUpper() == "LOCATION")
                    return Location;
                else if (Name.ToUpper() == "DEPARTMENT")
                    return Department;
                else if (Name.ToUpper() == "GENDER")
                    return Gender;
                else
                    return null;
            }

            // The set accessor is used to assigning a value
            set
            {
                if (Name.ToUpper() == "ID")
                    ID = Convert.ToInt32(value);
                else if (Name.ToUpper() == "NAME")
                    Name = value.ToString();
                else if (Name.ToUpper() == "JOB")
                    Job = value.ToString();
                else if (Name.ToUpper() == "SALARY")
                    Salary = Convert.ToDouble(value);
                else if (Name.ToUpper() == "LOCATION")
                    Location = value.ToString();
                else if (Name.ToUpper() == "DEPARTMENT")
                    Department = value.ToString();
                else if (Name.ToUpper() == "GENDER")
                    Gender = value.ToString();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Kamran", "DEV", 104000, "FSD", "IT", "Male");
            Console.WriteLine("EID = " + emp["ID"]);
            Console.WriteLine("Name = " + emp["Name"]);
            Console.WriteLine("Job = " + emp["job"]);
            Console.WriteLine("Salary = " + emp["salary"]);
            Console.WriteLine("Location = " + emp["Location"]);
            Console.WriteLine("Department = " + emp["department"]);
            Console.WriteLine("Gender = " + emp["Gender"]);
            //Seting values using arrays syntax
            emp["Name"] = "Ali";
            emp["salary"] = 3434543;
            emp["Location"] = "FSD";
            Console.WriteLine("=======Afrer Modification=========");
            Console.WriteLine("EID = " + emp["ID"]);
            Console.WriteLine("Name = " + emp["Name"]);
            Console.WriteLine("Job = " + emp["job"]);
            Console.WriteLine("Salary = " + emp["salary"]);
            Console.WriteLine("Location = " + emp["Location"]);
            Console.WriteLine("Department = " + emp["department"]);
            Console.WriteLine("Gender = " + emp["Gender"]);

            Console.ReadLine();
        }
    }
}