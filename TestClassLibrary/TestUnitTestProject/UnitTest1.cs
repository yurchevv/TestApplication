using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestClassLibrary;

namespace TestUnitTestProject
{
    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void GetAreaNotEqualStandart()
        {
            Triangle triangle = new Triangle();

            triangle.FirstSide = 5;

            triangle.SecondSide = 10;

            triangle.ThirdSide = 10;

            double area = triangle.GetHalfPerimeter();

            Assert.AreNotEqual(1, area);
        }

        [TestMethod]
        public void GetAreaNotNull()
        {
            Triangle triangle = new Triangle();

            triangle.FirstSide = 5;

            triangle.SecondSide = 10;

            triangle.ThirdSide = 10;

            double area = triangle.GetHalfPerimeter();

            Assert.AreNotEqual(null, area);
        }

        [TestMethod]
        public void GetAreaEqualStandart()
        {
            Triangle triangle = new Triangle();

            triangle.FirstSide = 3;

            triangle.SecondSide = 4;

            triangle.ThirdSide = 5;

            double area = triangle.GetHalfPerimeter();

            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void GetAreaIsPositive()
        {
            Triangle triangle = new Triangle();

            triangle.FirstSide = -3;

            triangle.SecondSide = -4;

            triangle.ThirdSide = -5;

            double area = triangle.GetHalfPerimeter();

            Assert.AreEqual(0, area);
        }
    }
}
