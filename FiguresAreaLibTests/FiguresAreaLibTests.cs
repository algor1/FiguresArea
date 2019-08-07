using System;
using NUnit.Framework;



namespace FigureasArea.Tests
{
    [TestFixture]   
    public class FiguresAreaLibTests
    {
        private FiguresAreaLib figuresAreaLib;
        
        [SetUp]
        public void TestInitialize()
        {
            figuresAreaLib = new FiguresAreaLib();
        }
        
        [Test]
        public void CircleArea_Radius2_return8PI()
        {
            double r = 2;
            double expected = 8*Math.PI;
            double actiual = figuresAreaLib.CircleArea(r);
            Assert.That(actiual, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        [TestCase (2,2,2.828427,2)]
        public void TriangleAreaTest_CorresctSides_returnedCorrect(double a,double b, double c,double expected)
        {
            double actiual = figuresAreaLib.TriangleArea(a, b, c);
            Assert.That(actiual ,Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        [TestCase(2, 2, 2.828427)]
        public void IsRightTriangleTest_CorrectSides_ReturnedTrue(double a, double b, double c)
        {
            bool actiual = figuresAreaLib.IsRightTriangle(a, b, c);
            Assert.That(actiual,Is.True);
        }

        [Test]
        [TestCase(2, 2, 6)]
        public void TriangleAreaTest_IncorresctSides_returnedExeption(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => figuresAreaLib.TriangleArea(a, b, c));
        }
    }
}