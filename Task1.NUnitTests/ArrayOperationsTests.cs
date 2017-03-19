using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class ArrayOperationsTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = null)]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1 }, ExpectedResult = null)]
        [TestCase(new int[] { 1, 1 }, ExpectedResult = null)]


        public int? FindTheCentral_NormalIntegerArray_PositiveTest(int[] array)
        {
            return ArrayOperations.FindTheCentral(array);
        }

        [TestCase(null)]
        
        public void FindTheCentral_ArgumentArrayIsNullReferenced_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => ArrayOperations.FindTheCentral(array));
        }

                
        [TestCase(new int[] { })]
                
        public void FindTheCentral_ArgumentArrayIsEmpty_ThrowsArgumentOutOfRangeException(int[] array)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayOperations.FindTheCentral(array));
        }
    }
}
