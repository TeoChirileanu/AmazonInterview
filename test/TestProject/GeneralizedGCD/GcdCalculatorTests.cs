using NFluent;
using NUnit.Framework;
using SourceProject.GeneralizedGCD;

namespace TestProject.GeneralizedGCD
{
    public class GcdCalculatorTests
    {
        [Test]
        public void ShouldReturn0_WhenNoNumbersAreGiven()
        {
            // Arrange
            IGcdCalculator calculator = new GcdCalculator();

            // Act
            var gcd = calculator.CalculateGcd(new int[0]);

            // Assert
            Check.That(gcd).IsEqualTo(0);
        }

        [Test]
        public void ShouldReturnTheNumber_WhenOnlyANumberIsGiven()
        {
            // Arrange

            // Act

            // Assert
        }

        [Test]
        public void ShouldReturnCorrectGcd_WhenSomeNumbersAreGiven()
        {
            // Arrange

            // Act

            // Assert
        }

        [Test]
        public void ShouldReturnAPositiveGcd_WhenSomeNegativeNumbersAreGiven()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
