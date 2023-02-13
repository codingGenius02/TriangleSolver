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
            int firstSide = 9;
            int secondSide = 9;
            int thirdSide= 9;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
