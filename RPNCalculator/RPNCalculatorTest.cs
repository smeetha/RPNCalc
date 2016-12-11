using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace RPNCalculator
{
    
    [TestFixture]
    public class RPNCalculatorTest
    {
        private RPNCalculator calc;

        [OneTimeSetUp]
        public void setUp()
        {
            calc = new RPNCalculator();

        }
        [Test]
       public void TestAdd()
        {
            Assert.AreEqual(4 + 5, calc.Apply(4, 5, "+"));

        }

        [Test]
        public void TestAdd1()
        {
            Assert.AreEqual(4 + 5, calc.Apply(14, 5, "+"));

        }
    }
}
