using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;
using System.Diagnostics;

namespace DDT.Task3.Test
{
    [TestClass]
    public class BitOperationsTest
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Numbers.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3.Tests\\Numbers.xml")]

        [TestMethod]
        public void Insertion_SecondNumberIsInsertedInFirstFromToSpecifiedPositions_ReturnsPositiveTest()
        {

            //Arrange
            if(TestContext.DataRow["FirstNumber"].ToString()=="int.MaxValue") TestContext.DataRow["FirstNumber"]=int.MaxValue;
            else if (TestContext.DataRow["FirstNumber"].ToString() == "int.MinValue") TestContext.DataRow["FirstNumber"] = int.MinValue;

            var number1 = Convert.ToInt32(TestContext.DataRow["FirstNumber"].ToString());

            if (TestContext.DataRow["SecondNumber"].ToString() == "int.MaxValue") TestContext.DataRow["SecondNumber"] = int.MaxValue;
            else if (TestContext.DataRow["SecondNumber"].ToString() == "int.MinValue") TestContext.DataRow["SecondNumber"] = int.MinValue;

            var number2 = Convert.ToInt32(TestContext.DataRow["SecondNumber"]);
            var i = Convert.ToInt32(TestContext.DataRow["i"]);
            var j = Convert.ToInt32(TestContext.DataRow["j"]);

            if (TestContext.DataRow["ExpectedResult"].ToString() == "int.MaxValue") TestContext.DataRow["ExpectedResult"] = int.MaxValue;
            else if (TestContext.DataRow["ExpectedResult"].ToString() == "int.MinValue") TestContext.DataRow["ExpectedResult"] = int.MinValue;
            var expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
           
            //Act
            var actual = BitOperations.Insertion(number1, number2, i, j);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Numbers.xml",
            "TestCase1",
            DataAccessMethod.Sequential)]


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Insertion_SecondNumberIsInsertedInFirstFromToSpecifiedPositions_ThrowsArgumentOutOfRangeException()
        {
            var number1 = Convert.ToInt32(TestContext.DataRow["FirstNumber"].ToString());
            var number2 = Convert.ToInt32(TestContext.DataRow["SecondNumber"]);
            var i = Convert.ToInt32(TestContext.DataRow["i"]);
            var j = Convert.ToInt32(TestContext.DataRow["j"]);
            var actual = BitOperations.Insertion(number1, number2, i, j);

        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Numbers.xml",
            "TestCase2",
            DataAccessMethod.Sequential)]


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Insertion_SecondNumberIsInsertedInFirstFromToSpecifiedPositions_ThrowsArgumentException()
        {
            var number1 = Convert.ToInt32(TestContext.DataRow["FirstNumber"].ToString());
            var number2 = Convert.ToInt32(TestContext.DataRow["SecondNumber"]);
            var i = Convert.ToInt32(TestContext.DataRow["i"]);
            var j = Convert.ToInt32(TestContext.DataRow["j"]);
            var actual = BitOperations.Insertion(number1, number2, i, j);

        }

    }
}
