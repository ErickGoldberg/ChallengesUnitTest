using NUnit.Framework.Interfaces;
using TestNinja.Fundamentals;

namespace TestNinjaTestes
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(15)]
        public void GetOutput_WhenConvert_ReturnCorrectString(int testCase)
        {
            var result = FizzBuzz.GetOutput(testCase);

            Assert.That(result == "FizzBuzz" || result == "Fizz" || result == "Buzz", "The number must be divisible for 3/5");
        }

        [Test]
        [TestCase(8)]
        public void GetOutput_WhenConvert_ReturnNumber(int testCase)
        {
            var result = FizzBuzz.GetOutput(testCase);

            Assert.That(result, Is.EqualTo("8"));
        }
    }
}