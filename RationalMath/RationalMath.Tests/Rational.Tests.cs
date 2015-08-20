using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RationalMath.Tests
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void TestCtor_DivideByZero_ThrowException()
        {
            try
            {
                var rat = new Rational(4, 0);
                Assert.Fail("Exception must be thrown in constructor ");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestCtor_CorretcData_Created()
        {
            var rat = new Rational(10, 4);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestProperties_SettingGetting_Passed()
        {
            var rat = new Rational(10, 4);

            Assert.AreEqual(10, rat.Numerator);
            Assert.AreEqual(4, rat.Denominator);

            rat.Denominator = -13;
            Assert.AreEqual(-13, rat.Denominator);

            rat.Numerator = 0;
            Assert.AreEqual(0, rat.Numerator);
        }

        [TestMethod]
        public void TestDenominator_SettingZero_thrownException()
        {
            var rat = new Rational(10, 7);
            try
            {
                rat.Denominator = 0;
                Assert.Fail("Denominator is Changed to zero but exception wasn't throw");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestCompare_withDoubleFloatInt_Passed()
        {
            var rat = new Rational(625, 5);
            Assert.AreEqual(125, (double) rat, "Invalid cast to double");
            Assert.AreEqual(125, (float) rat, "Invalid cast to float");
            Assert.AreEqual(125, (int) rat, "Invalid cast to int");
        }

        [TestMethod]
        public void TestAdd_WithOtherRational_Passed()
        {
            var rat = new Rational(625, 5);
            var other = new Rational(338, 13);
            var sum = rat + other;
            Assert.AreEqual(151, (double) sum, "Invalid Sum operation");
        }

        [TestMethod]
        public void TestMinus_WithOtherRational_Passed()
        {
            var rat = new Rational(625, 5);
            var other = new Rational(338, 13);
            var minus = rat - other;
            Assert.AreEqual(99, (double) minus, "Invalid minus operation");
        }

        [TestMethod]
        public void TestMultiply_WithOtherRational_Passed()
        {
            var rat = new Rational(625, 5);
            var other = new Rational(338, 13);
            var mult = rat*other;
            Assert.AreEqual(3250, (double) mult, "Invalid multiply operation");
        }

        [TestMethod]
        public void TestDivide_WithOtherRational_Passed()
        {
            var rat = new Rational(7, 5);
            var other = new Rational(5, 7);
            var div = rat/other;
            Assert.AreEqual(49, div.Numerator, "Invalid divide operation");
            Assert.AreEqual(25, div.Denominator, "Invalid divide operation");
        }
    }
}