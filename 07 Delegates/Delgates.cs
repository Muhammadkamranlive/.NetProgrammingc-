using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WeekTow._07_Delegates
{
    public class Delegates
    {
        // declaration 
        delegate int delegateAdd(int x, int y);
        static int Add(int x, int y)
        {
            return x + y;
        }
        // Multicast Delegate
        delegate void Delegate_Multicast(int x, int y);

        static void Method1(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Method1 is called");
            Console.WriteLine(" Sum is : {0}", z);
        }
        static void Method2(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Method2 is called");
            Console.WriteLine("Sum is : {0}", z);
        }

        // Methods for generic Delegates
        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

        public static void Main(string[] ards)
        {

            //create delegate instance
            delegateAdd objAdd = new delegateAdd(Add);
            //short hand for above statement
            delegateAdd objAdd = Add;

            // Invoke delegate to call method
            int result = objAdd.Invoke(3, 6);
            //short hand for above statement
            int result = objAdd(3, 6);

            //invoke multicast delegate
            Delegate_Multicast dmulti = Method1;
            dmulti += Method2;
            dmulti(1, 2); // Method1 and Method2 are called
            dmulti -= Method1;
            dmulti(2, 3); // Only Method2 is called

            // Generic Delegates of base class

            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);
            double Result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(Result);

            Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);
            obj2.Invoke(50, 255.45f, 123.456);

            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            bool Status = obj3.Invoke("Kamran");
            Console.WriteLine(Status);


        }
    }
}
