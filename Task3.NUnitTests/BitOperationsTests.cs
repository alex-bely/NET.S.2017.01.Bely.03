using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task3;

namespace Task3.NUnitTests
{
    [TestFixture]
    public class BitOperationsTest
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]
        public int Insertion_Number2ISInsertedInNumber1FromStartPositionToFinishPosition_PositiveTest(int first, int second, int startPosition, int finishPosition)
        {
            return BitOperations.Insertion(first, second, startPosition, finishPosition);
        }

        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 32, 5)]
        [TestCase(8, 15, 5, 32)]
        public void Insertion_StartOrFinishPositionIsOutOfRange_ThrowsArgumentOutOfRangeException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BitOperations.Insertion(first, second, startPosition, finishPosition));
        }

        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        public void Insertion_StartPositionIsLargerThenFinishPosition_ThrowsArgumentException(int first, int second, int startPosition, int finishPosition)
        {
            Assert.Throws<ArgumentException>(() => BitOperations.Insertion(first, second, startPosition, finishPosition));
        }
    }



}

