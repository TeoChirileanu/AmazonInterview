using System;
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
        public void ShouldReturnTheNumber_WhenOnlyAPositiveNumberIsGiven()
        {
            // Arrange
            IGcdCalculator calculator = new GcdCalculator();
            var x = new Random().Next(0, 100);

            // Act
            var gcd = calculator.CalculateGcd(new[] {x});

            // Assert
            Check.That(gcd).IsEqualTo(x);
        }

        [Test]
        public void ShouldReturnTheNumber_WhenOnlyANegativeNumberIsGiven()
        {
            // Arrange
            IGcdCalculator calculator = new GcdCalculator();
            var x = new Random().Next(0, 100) * -1;

            // Act
            var gcd = calculator.CalculateGcd(new[] {x});

            // Assert
            Check.That(gcd).IsEqualTo(-x);
        }

        [TestCase(2, 3, 4, 5, 6)]
        public void ShouldReturnCorrectGcd_WhenSomeNumbersAreGiven(params int[] numbers)
        {
            // Arrange
            IGcdCalculator calculator = new GcdCalculator();

            // Act
            var gcd = calculator.CalculateGcd(numbers);

            // Assert
            Check.That(gcd).IsEqualTo(1);
        }

        [TestCase(2, 4, 6, 8, 10)]
        public void ShouldReturnCorrectGcd_WhenOtherNumbersAreGiven(params int[] numbers)
        {
            // Arrange
            IGcdCalculator calculator = new GcdCalculator();

            // Act
            var gcd = calculator.CalculateGcd(numbers);

            // Assert
            Check.That(gcd).IsEqualTo(2);
        }

        [TestCase(2, -4, 6, -8, 10)]
        public void ShouldReturnAPositiveGcd_WhenSomeNegativeNumbersAreGiven(params int[] numbers)
        {
            // Arrange
            IGcdCalculator calculator = new GcdCalculator();

            // Act
            var gcd = calculator.CalculateGcd(numbers);

            // Assert
            Check.That(gcd).IsEqualTo(2);
        }
    }
}