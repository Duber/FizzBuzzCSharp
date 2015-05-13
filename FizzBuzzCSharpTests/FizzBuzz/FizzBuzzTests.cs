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
           Assert.AreEqual("Fizz", FizzBuzz.Calculate(3));
        }

        [TestMethod]
        public void WhenFiveThenBuzz()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Calculate(5));
        }

        [TestMethod]
        public void WhenFiveTeenThenFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Calculate(15));
        }

        [TestMethod]
        public void GivenANonDivisibleNumberThenSameNumberIsReturned()
        {
            Assert.AreEqual("2", FizzBuzz.Calculate(2));
        }
    }
}