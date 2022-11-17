using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WeekTow.DataTypes
{
    public class Basics
    {
        private  void Main(string[] args)
        {
            string firstName ="Muhammad";
            string lastName="Kamran";
            int number = 50;
            long longAmount = 34344;
            float floatAmount = 232.50f;
            double bigAmount=3434343434334.4;
            char charVariable = 'A';
            //Implicit Typ casting
            // char -> int -> long -> float -> double
           
            //Implicit Casting
            //Implicit casting is done automatically when passing a smaller size type to a larger size type: 
            
            firstName = charVariable.ToString();
            number =int.Parse(firstName);
            longAmount=number;
            floatAmount=longAmount;
            bigAmount = longAmount;

            //Explicit Casting
            //Explicit casting must be done manually by placing the type in parentheses in front of the value:
            floatAmount = (float)bigAmount;
            longAmount=(long)bigAmount;
            number=(int)bigAmount;

            //Type Conversion Methods
            //It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long): 

            number = Convert.ToInt32(longAmount);
            floatAmount=Convert.ToInt64(number);
            bigAmount=(float)bigAmount;
            Console.ReadLine();
            // Math class in the  c#
            Math.Abs(number);
            Math.Cos(45);
            Math.Max(23,40);
            Math.Floor(30.4);
            Math.Ceiling(34.4564);
            Math.Sqrt(90);
            Math.Pow(30,5);
            Math.Min(23, 4);
          
        }
    }
}
