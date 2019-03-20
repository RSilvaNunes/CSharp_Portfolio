using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raquel_da_Silva_Nunes_Lab_1B_Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };


            Console.WriteLine("DisplayArray Method:");
            Console.WriteLine("--------------------");
            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument

            Console.WriteLine("\n");
            Console.WriteLine("DisplayArray Overload Method:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("intArray contains " + DisplayArray(intArray, 1, 4) + " elements.");
            Console.WriteLine("doubleArray contains " + DisplayArray(doubleArray, 2, 3) + " elements.");
            Console.WriteLine("charArray contains " + DisplayArray(charArray, 2, 3) + " elements.");
        }

        // output array of all types                           
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        //Overloading DisplayArray
        private static int DisplayArray<T>(T[] inputArray, int lowindex, int highindex)
        {
            // Validate if lowindex or highindex is out of range
            if (lowindex > inputArray.Length || highindex > inputArray.Length || lowindex >= highindex)
            {
                throw new ArgumentException("Index is out of range.");
            }

            int counter = 0;

            for (int i = lowindex; i <= highindex; i++)
            {
                Console.Write($"{inputArray[i]}" + ",");
                counter++;
            }

            return counter;
        }
    }
}