using NFluent;
using NUnit.Framework;
using SourceProject.EightHouses;

namespace TestProject.EightHouses
{
    public class HousesTests
    {
        [Test]
        public void Day1Tests()
        {
            // Arrange
            var initialStates = new[] {1, 0, 0, 0, 0, 1, 0, 0};
            var expectedStates = new[] {0, 1, 0, 0, 1, 0, 1, 0};
            const int days = 1;

            // Act
            var finalStates = Houses.Compete(initialStates, days);

            // Assert
            Check.That(finalStates).ContainsExactly(expectedStates);
        }

        [Test]
        public void Day2Tests()
        {
            // Arrange
            var initialStates = new[] {1, 1, 1, 0, 1, 1, 1, 1};
            var expectedStates = new[] {0, 0, 0, 0, 0, 1, 1, 0};
            const int days = 2;

            // Act
            var finalStates = Houses.Compete(initialStates, days);

            // Assert
            Check.That(finalStates).ContainsExactly(expectedStates);
        }
    }
}