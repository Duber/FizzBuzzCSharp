using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzCSharp.FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCSharp.FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void WhenThreeThenFizz()
        {
            Assert.IsTrue(ExpectedIsEqualToCalculated("Fizz", 3));
        }

        [TestMethod]
        public void WhenFiveThenBuzz()
        {
            Assert.IsTrue(ExpectedIsEqualToCalculated("Buzz", 5));
        }

        [TestMethod]
        public void WhenFiveTeenThenFizzBuzz()
        {
            Assert.IsTrue(ExpectedIsEqualToCalculated("FizzBuzz", 15));
        }

        [TestMethod]
        public void GivenANonDivisibleNumberThenSameNumberIsReturned()
        {
            Assert.IsTrue(ExpectedIsEqualToCalculated("2", 2));
        }

        private bool ExpectedIsEqualToCalculated(string expected, int number)
        {
            return (expected == FizzBuzz.Calculate(number));
        }
    }
}