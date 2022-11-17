using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WeekTow._04_Arrays
{
    internal class ArrayClass
    {


        static void Main(string[] args)
        {
            //Array Declaration style of the single  dimensional arrays
            int[] myArray= new int[] { 1, 2, 3 };
            int[] secondArrayStyle = { 1, 2, 3, 3, 3, 3, 3, 3, 3 };
            var mayArrayUingVar = new String[] { "kami", "ali", "ahamed" };
            //Array declaration style of the 2d Array

            int[,] number = { { 1212, 3, 33 }, { 23, 34, 4 } };
            //  3D Arrays  and so on we can create 
            int[,,] threeDimensionalArray = { { { 12, 3, 3, 34 }, { 1, 2, 2, 3 } }, { { 222, 2, 2, 3 } , { 222, 2, 2, 3 } } };

            //A jagged array is an array of array. Jagged arrays store arrays instead of literal values.
            //A jagged array is initialized with two square brackets[][].
            //The first bracket specifies the size of an array, and the second bracket specifies the dimensions
            //of the array which is going to be stored.
            int[][,] jArray = new int[2][,];

            jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };

            int[][][] intJaggedArray = new int[2][][]
                             {
                                new int[2][]
                                {
                                    new int[3] { 1, 2, 3},
                                    new int[2] { 4, 5}
                                },
                                new int[1][]
                                {
                                    new int[3] { 7, 8, 9}
                                }
                            };



        }
    }
}
