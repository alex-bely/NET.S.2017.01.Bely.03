using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2.NUnitTests
{
    [TestFixture]
    public class StringOperationsTests
    {
        [TestCase("xyaabbdcccdefww", "xxxxyyyyabklmopq", ExpectedResult = "abcdefklmopqwxy")]
        [TestCase("xxxxyyyyabklmopq", "xyaabbdcccdefww", ExpectedResult = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        [TestCase("n", "l", ExpectedResult = "ln")]
        public string Longest_FirstStringConcatSecondStringDistinctingDuplicateSymbolsInAlpabeticalOrder_PositiveTest(string firstString, string secondString)
        {
            return StringOperations.Longest(firstString, secondString);
        }

        [TestCase("xyaabbdcccdefww",null)]
        [TestCase(null, "xyaabbdcccdefww")]
        [TestCase(null, null)]
        public void Longest_FirstStringOrSecondStringOrBothAreNullReferenced_ThrowsArgumentNullException(string firstString, string secondString)
        {
            Assert.Throws < ArgumentNullException>(() => StringOperations.Longest(firstString, secondString));
        }

        [TestCase("xyaabbd cccdefww", "xxxxyyyyabklmopq")]
        [TestCase("xyaabbdcccdefww", "xxxxyyyy abklmopq")]
        [TestCase("xyaabBdcccdefww", "xxxxyyyyabklmopq")]
        [TestCase("xyaabbdcccdefww", "xxxxyyyyBabklmopq")]
        [TestCase("xyaabbdcЮcdefww", "xxxxyyyy abklmopq")]
        [TestCase("xyaabbdcccdefww", "xxxxyyyyЮabklmopq")]
        public void Longest_FirstStringOrSecondStringOrBothContainIncorrectSymbols_ThrowsArgumentOutOfRangeException(string firstString, string secondString)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => StringOperations.Longest(firstString, secondString));
        }

        [TestCase("xyaabbdcccdefww", "")]
        [TestCase("", "xxxxyyyy abklmopq")]
        [TestCase("", "")]
        public void Longest_FirstStringOrSecondStringOrBothAreEmpty_ThrowsArgumentException(string firstString, string secondString)
        {
            Assert.Throws<ArgumentException>(() => StringOperations.Longest(firstString, secondString));
        }
    }
}
