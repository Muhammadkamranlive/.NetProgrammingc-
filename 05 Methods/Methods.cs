using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace WeekTow._05_Methods
{
    public class MotorCycle
    {
        //anonymous methods 
        delegate int del(ini firstParam, int secondParam);
        // Anyone can call this.
        public void StartEngine() {/* Method statements here */ }

        // Only derived classes can call this.
        protected void AddGas(int gallons) { /* Method statements here */ }

        // Derived classes can override the base class implementation.
        public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

        // Derived classes can override the base class implementation.
        public virtual int Drive(TimeSpan time, int speed) { /* Method statements here */ return 0; }

        // drive method above show the method overloading  implementations
        // Derived classes must implement this.
        public abstract double GetTopSpeed();


    }

    // Inherited and overridden methods

    class TestMotorcycle : Motorcycle
    {
        public override int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0);
        }

        public override double GetTopSpeed()
        {
            return 108.4;
        }
        // Extension Method
        public static class MyExtensions
        {
            public static int WordCount(this string str)
            {
                return str.Split(new char[] { ' ', '.', '?' },
                                 StringSplitOptions.RemoveEmptyEntries).Length;
            }
        }


        static void Main()
        {

            TestMotorcycle moto = new TestMotorcycle();
            moto.StartEngine();
            moto.AddGas(15);
            var travelTime = moto.Drive(speed: 60, miles: 170);
            Console.WriteLine("Travel time: approx. {0} hours", travelTime);
            // calling extension method
            string s = "Hello Extension Methods";
            int i = s.WordCount();
        }
    }

    // Layer Spefice Fnctionality with Extension Methods
    public class DomainEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    static class DomainEntityExtensions
    {
        public static string FullName(this DomainEntity value) => $"{value.FirstName} {value.LastName}";
    }


    public class Methods
    {
        //Async Methods

        static async Task DoSomethingAsync()
        {

            int result = await DelayAsync();

            Console.WriteLine($"Result: {result}");
        }

        static async Task<int> DelayAsync()
        {
            await Task.Delay(100);
            return 5;
        }

        static void Main(string[] args)
        {
            // anonymous method 
            del delegateObject = delegate (int x, int y) { return x + y; };
            //Extension Method
            DomainEntity Obj = new DomainEntity();
            Obj.FullName();
        }
    }

}