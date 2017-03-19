using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;

namespace TasksCUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int[] intArray1 = { 1, 2, 3, 4, 3, 2, 1 };
            int[] intArray2 = { 1, 100, 50, -51, 1, 1 };
            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            int[] intArray4 = { 0, 0, 0, 0, 0 };
            
            Console.WriteLine(ArrayOperations.FindTheCentral(intArray1));
            Console.WriteLine(ArrayOperations.FindTheCentral(intArray2));
            Console.WriteLine(ArrayOperations.FindTheCentral(intArray3));
            Console.WriteLine(ArrayOperations.FindTheCentral(intArray4));
            Console.WriteLine();

            //Task2
            string firstString = "xyaabBdcccdefww";
            string secondString = "xxxxyyyyabklmopq";
            string thirdString = "abcdefghijklmnopqrstuvwxyz";
           
            string firstPlusSecond = StringOperations.Longest(firstString, secondString);
            thirdString = StringOperations.Longest(thirdString, thirdString);
            
            Console.WriteLine(firstPlusSecond);
            Console.WriteLine(thirdString);
            Console.WriteLine();

            //Task3
             int result = BitOperations.Insertion(8, 15, 0, 0);
             Console.WriteLine(result);
             result = BitOperations.Insertion(0, 15, 30, 30);
             Console.WriteLine(result);
             result = BitOperations.Insertion(0, 15, 0, 30);
             Console.WriteLine(result);
             result = BitOperations.Insertion(15, -15, 0, 4);
             Console.WriteLine(result);
             result = BitOperations.Insertion(15, int.MaxValue, 3, 5);
             Console.WriteLine(result);

            /*[TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
            [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
            [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
            [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
            [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
            [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
            [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]*/
           

            Console.WriteLine(BitOperations.Insertion(int.MaxValue, int.MaxValue, 3, 5));
            Console.WriteLine(BitOperations.Insertion(15, int.MaxValue, 3, 5));
            Console.WriteLine(BitOperations.Insertion(15, 15, 1, 3));
            Console.WriteLine(BitOperations.Insertion(15, 15, 1, 4));
            Console.WriteLine(BitOperations.Insertion(15, -15, 0, 4));
            Console.WriteLine(BitOperations.Insertion(15, -15, 1, 4));
            Console.WriteLine(BitOperations.Insertion(-8, -15, 1, 4));


            Console.ReadLine();

        }
    }
}
