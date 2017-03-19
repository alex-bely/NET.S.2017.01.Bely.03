using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Provides additional tools for handling with decimal numbers
    /// </summary>
    public static class BitOperations
    {
        /// <summary>
        /// Inserts second number in the first one by inserting bits of the second number from and to specified positions of the first one
        /// </summary>
        /// <param name="number1">Integer number which bits are replaced with the bits of the other number</param>
        /// <param name="number2">Integer number which bits replace the bits of the other number</param>
        /// <param name="startPosition">Start position of replacement</param>
        /// <param name="endPosition">End position of replacement</param>
        /// <returns>Decimal number, made by inserting bits from one number into the other</returns>
        /// <exception cref="ArgumentException">Second position is larger than first one</exception>
        /// <exception cref="ArgumentOutOfRangeException">One of the arguments is out of range</exception>
        public static int Insertion(int number1, int number2, int startPosition, int endPosition)
        {
            if (startPosition < 0 || endPosition < 0 || startPosition > 30 || endPosition > 30) throw new ArgumentOutOfRangeException();
            if (startPosition > endPosition) throw new ArgumentException();
           

             
            BitArray bitArray1 = new BitArray(new int[] { number1 });
            BitArray bitArrray2 = new BitArray(new int[] { number2 });
                        
                      
            for (int z = startPosition, k = 0; z <= endPosition; z++, k++)
                bitArray1[z] = bitArray1[z]|bitArrray2[k];


            int[] array = new int[1];
            bitArray1.CopyTo(array, 0);
            return array[0];
                       
        }
    }
}
