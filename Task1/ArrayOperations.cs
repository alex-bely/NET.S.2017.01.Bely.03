using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Provides additional tools for handling with arrays
    /// </summary>

    public static class ArrayOperations
    {

        /// <summary>
        /// Searches for the index of such element that the sum of all previous elements is equal to the sum of all next elements.
        /// </summary>
        /// <param name="array">Source array for looking for the index</param>
        /// <returns>Index of such element that the sum of all previous elements is equal to the sum of all next elements or null</returns>
        /// <exception cref="ArgumentNullException">Argument is null reference</exception>
        /// <exception cref="ArgumentOutOfRangeException">Argument is out of range</exception>
        public static int? FindTheCentral(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            if (array.Length < 1 || array.Length > 999)
                throw new ArgumentOutOfRangeException();

            for (int i = 1; i < array.Length - 1; i++)
            {
                int leftPartSum = array.Take(i).Sum();
                int rightPartSum = array.Skip(i + 1).Take(array.Length - i - 1).Sum();
                if (leftPartSum == rightPartSum) return i;
            }
            return null;
        }


       
    }
}
