using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using System.Security.Policy;

namespace TriangleTestClass
{
    [TestFixture]
    public class TriangleTest
    {
        Triangle objTesting = new Triangle();

        //Only 1 test for valid equilateral triangle
        [Test]
        public void TestEquilateralTriangle_Input7andInput7andInput7_Equal()
        {
            //arrange
            int firstSide = 7;
            int secondSide = 7;
            int thirdSide = 7;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //1st test for valid isosceles triangle
        [Test]
        public void TestIsoscelesTriangle_Input4andInput4andInput5_AllEqual()
        {
            //arrange
            int firstSide = 4;
            int secondSide = 4;
            int thirdSide = 5;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //2nd test for valid isosceles triangle
        [Test]
        public void TestIsoscelesTriangle_Input4andInput5andInput4_TwoSidesEqual()
        {
            //arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 4;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //3rd test for valid isosceles triangle
        [Test]
        public void TestIsoscelesTriangle_Input5andInput4andInput4_TwoSidesEqual()
        {
            //arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 4;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        
