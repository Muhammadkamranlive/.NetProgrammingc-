using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace WeekTow._03Iterations
{
    internal class Iterations
    {
      private  void main (string[] args)
        {
            //The while loop loops through a block of code as long as a specified condition is True:
            int number = 0;
            while(number <=20)
            {
                Console.WriteLine("Now the numnber is :->"+ number);
                number++;
            }

            //When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is for loop execution :->" + i);
            }

            //There is also a foreach loop, which is used exclusively to loop through elements in an array:
            var IntegerArray = new int[] { 1, 2, 2, 23, 3, 3, 3, 3, 3, 3, 3, 3, 4, 34, 4 };
            foreach (var item in IntegerArray)
            {
                Console.WriteLine("This is for each syntax for loop through the arry :" + item);
            }

            //Break and continue statements
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                else if (i==3)
                {
                    continue;
                    Console.WriteLine(i);
                }
               
            }


        }
    }
}
