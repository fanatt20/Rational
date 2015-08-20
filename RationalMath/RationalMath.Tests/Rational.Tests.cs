using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RationalMath.Tests
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void TestCtor_DivideByZero_ThrowException()
        {
            try {
                var rat = new Rational(4, 0);
                //if object created
                Assert.Fail("");
            }
            catch(DivideByZeroException) {
                //this exception is right
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestCtor_CorretcData_Created()
        {
            var rat = new Rational(10, 4);
            //mean that we can create object with correct data
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestProperties_SettingGetting_Passed()
        {
            var rat = new Rational(10, 4);
            //values that passed in ctor was accociated with Numerator and Denominator
            Assert.AreEqual(rat.Numerator, 10);
            Assert.AreEqual(rat.Denominator, 4);

            rat.Denominator = -13;
            Assert.AreEqual(rat.Denominator, -13);
            rat.Numerator = 0;
            Assert.AreEqual(rat.Numerator, 0);
        }

        [TestMethod]
        public void TestDenominator_SettingZero_thrownException()
        {
            var rat = new Rational(10, 7);
            try {
                rat.Denominator = 0;
                Assert.Fail("");
            }
            catch(DivideByZeroException) {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestCompare_withDoubleFloatInt_Passed()
        {
            var rat = new Rational(625, 5);
            Assert.AreEqual(125, (double)rat);
            Assert.AreEqual(125, (float)rat);
            Assert.AreEqual(125, (int)rat);
        }
        [TestMethod]
        public void TestAdd_WithOtherRational_Passed()
        {
            var rat = new Rational(625, 5);
            var other = new Rational(338, 13);
            var sum = rat + other;
            Assert.AreEqual(151, (double)sum);
        }
        [TestMethod]
        public void TestMinus_WithOtherRational_Passed()
        {
            var rat = new Rational(625, 5);
            var other = new Rational(338, 13);
            var minus = rat - other;
            Assert.AreEqual(99, (double)minus);
        }
        [TestMethod]
        public void TestMultiply_WithOtherRational_Passed()
        {
            var rat = new Rational(625, 5);
            var other = new Rational(338, 13);
            var mult = rat * other;
            Assert.AreEqual(3250, (double)mult);
        }
        [TestMethod]
        public void TestDivide_WithOtherRational_Passed()
        {
            var rat = new Rational(625, 5);
            var other = new Rational(338, 13);
            var div = rat / other;
            Assert.AreEqual(125, div.Numerator);
            Assert.AreEqual(26,div.Denominator);
        }
        
    }
}