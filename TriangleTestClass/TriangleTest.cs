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

        //1st test for valid scalene triangle
        [Test]
        public void TestScaleneTriangle_Input4andInput5andInput6_NoEqualSides()
        {
            //arrange
            int firstSide = 4;
            int secondSide = 5;
            int thirdSide = 6;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //2nd test for valid scalene triangle
        [Test]
        public void TestScaleneTriangle_Input8andInput6andInput10_NoEqualSides()
        {
            //arrange
            int firstSide = 8;
            int secondSide = 6;
            int thirdSide = 10;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //3rd test for valid scalene triangle
        [Test]
        public void TestScaleneTriangle_Input1andInput2andInput3_NoEqualSides()
        {
            //arrange
            int firstSide = 7;
            int secondSide = 8;
            int thirdSide = 9;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //4th test for valid scalene triangle
        [Test]
        public void TestScaleneTriangle_Input5andInput10andInput15_NoEqualSides()
        {
            //arrange
            int firstSide = 6;
            int secondSide = 12;
            int thirdSide = 14;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //5th test for valid scalene triangle
        [Test]
        public void TestScaleneTriangle_Input3andInput6andInput9_NoEqualSides()
        {
            //arrange
            int firstSide = 15;
            int secondSide = 16;
            int thirdSide = 17;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //1st test for verifying a zero length for one or more sides
        [Test]
        public void TestTriangleZeroLength_Input0andInput0andInput0_0()
        {
            //arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //2nd test for verifying a zero length for one or more sides
        [Test]
        public void TestTriangleZeroLength_Input0andInput0andInput1_0()
        {
            //arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 1;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //3rd test for verifying a zero length for one or more sides
        [Test]
        public void TestTriangleZeroLength_Input1andInput0andInput1_0()
        {
            //arrange
            int firstSide = 1;
            int secondSide = 0;
            int thirdSide = 1;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //1st test for verifying an invalid response (other than 0)
        [Test]
        public void TestTriangleInvalidResponse_InputNeg1andInput2andInput3_Invalid()
        {
            //arrange
            int firstSide = -1;
            int secondSide = 2;
            int thirdSide = 3;

            string expected = "Based on the values entered, the triangle is INVALID";
            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //2nd test for verifying an invalid response (other than 0)
        [Test]
        public void TestTriangleInvalidResponse_Input3andInputNeg6andInput10_Invalid()
        {
            //arrange
            int firstSide = 3;
            int secondSide = -6;
            int thirdSide = 10;

            string expected = "Based on the values entered, the triangle is INVALID";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //3rd test for verifying an invalid response (other than 0)
        [Test]
        public void TestTriangleInvalidResponse_InputNeg2andInputNeg4andInputNeg6_Invalid()
        {
            //arrange
            int firstSide = -2;
            int secondSide = -4;
            int thirdSide = -6;

            string expected = "Based on the values entered, the triangle is INVALID";

            //act
            string actual = objTesting.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
