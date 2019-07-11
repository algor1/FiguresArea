using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureasArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FigureasArea.Tests
{
    [TestClass()]
    public class FiguresAreaLibTests
    {
        private FiguresAreaLib figuresAreaLib;
        
        [TestInitialize]
        public void TestInitialize()
        {
            figuresAreaLib = new FiguresAreaLib();
        }
        
        [TestMethod()]
        public void CircleAreaTest2_4returned()
        {
            //arrange
            double r = 2;
            double expected = 8*Math.PI;
            //act
            double actiual = figuresAreaLib.CircleArea(r);
            //assert
            Assert.AreEqual(expected, actiual);
        }

        [TestMethod()]
        public void TriangleAreaTest_2_2_sqrt8_2returned()
        {
            //arrange
            double a = 2;
            double b = 2;
            double c = Math.Sqrt(8);
            double expected = 2;
            double delta= 0.0000001;
            
            //act
            double actiual = figuresAreaLib.TriangleArea(a, b, c);

            //assert
            Assert.AreEqual(expected, actiual,delta);
            
        }
        [TestMethod()]
        public void IsRightTriangleTest_2_2_sqrt8_true_returned()
        {
            //arrange
            double a = 2;
            double b = 2;
            double c = Math.Sqrt(8);
            //act
            double actiual = figuresAreaLib.IsRightTriangle(a, b, c);

            //assert
            Assert.IsTrue(actiual);
        }
    }
}