using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreOfCircle()
        {
            Circle circle = new Circle(5);
            double area = Math.Round(circle.GetArea(),1);
            Assert.AreEqual(78.5,area);
        }

        [TestMethod]
        public void TestAreOfSquare()
        {
            Square square = new Square(5);
            double area = Math.Round(square.GetArea(), 1);
            Assert.AreEqual(25,area);
        }

        [TestMethod]
        public void TestAreOfRectangle()
        {
            Rectangle rectangle = new Rectangle(5,6);
            double area = Math.Round(rectangle.GetArea(), 1);
            Assert.AreEqual(30,area);
        }


        [TestMethod]
        public void TestAreOfTriangle()
        {
            Triangle triangle = new Triangle(5, 6);
            double area = Math.Round(triangle.GetArea(), 1);
            Assert.AreEqual(15,area);
        }

        [TestMethod]
        public void TestAreOfTriangle_2()
        {
            Triangle triangle = new Triangle(5, 6, 7);
            double area = Math.Round(triangle.GetArea(), 1);
            Assert.AreEqual(14.7,area);
        }
    }
}
