using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculator;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CalculateSquareBoundaryTest()
        {
            //Arrange
            double d = 100;
            //Act
            double boundary = d * 4;
            //Assert
            Assert.AreEqual(400, boundary);
        }

        [TestMethod]
        public void CalculateSquareAreaTest()
        {
            //Arrange
            double d = 100;
            //Act
            double area = d * d;
            //Assert
            Assert.AreEqual(10000, area);
        }

        [TestMethod]
        public void CalculateCircleBoundaryTest()
        {
            //Arrange
            double d = 100;
            double expectedResult;
            //Act
            double boundary = Math.PI * d;
            expectedResult = Math.PI * d;
            //Assert
            Assert.AreEqual(expectedResult, boundary);
        }

        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            //Arrange
            double d = 100;
            double expectedResult;
            //Act
            double area = Math.PI * Math.Pow((d / 2), 2);
            expectedResult = Math.PI * Math.Pow((d / 2), 2);
            //Assert
            Assert.AreEqual(expectedResult, area);
        }

        [TestMethod]
        public void CalculateTriangleBoundaryTest()
        {
            //Arrange
            double d = 100;
            double expectedResult;
            //Act
            double boundary = (2 * d) + (Math.Sqrt(2 * d * d));
            expectedResult = (2 * 100) + (Math.Sqrt(2 * 100 * 100));
            //Assert
            Assert.AreEqual(expectedResult, boundary);
        }

        [TestMethod]
        public void CalculateTriangleAreaTest()
        {
            //Arrange
            double d = 100;
            //Act
            double area = d / 2 * d;
            //Assert
            Assert.AreEqual(5000, area);
        }
    }
}
