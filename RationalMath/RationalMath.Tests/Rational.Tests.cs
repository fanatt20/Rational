using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalMath;
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
                Assert.Fail("");
            }
            catch(DivideByZeroException) {

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
            Assert.IsTrue(rat.Numerator == 10 && rat.Denominator == 4);
            rat.Denominator = -13;
            Assert.IsTrue(rat.Denominator == -13);
            rat.Numerator = 0;
            Assert.IsTrue(rat.Numerator == 0);
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
        public void TestCompare_withDouble_Passed()
        {


        }
    }
}
