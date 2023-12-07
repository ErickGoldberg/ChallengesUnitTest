using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinjaTestes
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        DemeritPointsCalculator demeritPointsCalculator;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            demeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        public void CalculateDemeritPoints_NegativeSpeed_ReturnsArgumentOutOfRangeException()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(-10));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedGreaterThanMaxSpeed_ReturnsArgumentOutOfRangeException()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(350));
        }

        [Test]
        public void CalculateDemeritPoints_speedLessThanLimit_ReturnsZero()
        {
            // Act
            var result = demeritPointsCalculator.CalculateDemeritPoints(50);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        [TestCase(70)]
        [TestCase(85)]
        [TestCase(200)]
        public void CalculateDemeritPoints_speedGreaterThanLimit_ReturnsDemeritPoints(int testCase)
        {
            // Act
            var result = demeritPointsCalculator.CalculateDemeritPoints(testCase);

            // Assert
            Assert.Greater(result, 0);
        }

        [Test]
        public void CalculateDemeritPoints_CalculatingDemertiPoints_ReturnsCorrectDemeritPoints()
        {
            // Act
            var result = demeritPointsCalculator.CalculateDemeritPoints(85);

            // Assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}
