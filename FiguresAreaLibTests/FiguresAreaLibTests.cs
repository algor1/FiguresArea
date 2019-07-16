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
        public void CircleAreaTest2_4returned()
        {
            double r = 2;
            double expected = 8*Math.PI;
            double actiual = figuresAreaLib.CircleArea(r);
            Assert.That(actiual, Is.EqualTo(expected).Within(0.00001));
        }

        [Test]
        public void TriangleAreaTest_2_2_sqrt8_2returned()
        {
            double a = 2;
            double b = 2;
            double c = Math.Sqrt(8);
            double expected = 2;
            double delta= 0.0000001;
            
            double actiual = figuresAreaLib.TriangleArea(a, b, c);

            Assert.That(actiual ,Is.EqualTo(expected).Within(delta));
            
        }
        [Test]
        public void IsRightTriangleTest_2_2_sqrt8_true_returned()
        {
            double a = 2;
            double b = 2;
            double c = Math.Sqrt(8);
            bool actiual = figuresAreaLib.IsRightTriangle(a, b, c);

            Assert.That(actiual,Is.True);
        }
    }
}