// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using HW_5_Calc;
using WMPLib;
using System.IO;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        public double c;
        [OneTimeSetUp]       
        public void Hook()
        {
            c = 10;           
        }

        
        [Test(Description = "Использовал хук с=10 и проверил поднесение в степень функцией power")]
        public void Power10()
        {
           
            double answer = Program.power(4, c);
            Assert.That(answer, Is.EqualTo(1048576), "Some useful error message");
        }


        [TestCase(120, 2,10)]        
        public void Dividing(double a, double b, double expRes)
        {
             double actRes = Program.divide(a, b + c);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(1, 2, 2)]
        [TestCase(10, 2, 20)]
        [TestCase(0.5, 1, 0.5)]
        [TestCase(-5, -4, 20)]
        [TestCase(0, 33549, 0)]
        public void Multiplying(double a, double b, double expRes)
        {
            double actRes = Program.multiply(a, b);
            Assert.AreEqual(expRes, actRes);
            
        }

    }
}
