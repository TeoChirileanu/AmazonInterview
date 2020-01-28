using System;
using System.Linq;
using NFluent;
using NUnit.Framework;
using SourceProject.EightHouses;

namespace TestProject.EightHouses
{
    public class EightHousesTests
    {
        [Test]
        public void ShouldReturnAnArrayWithStates()
        {
            // Arrange
            IEightHouses houses = new SourceProject.EightHouses.EightHouses();
            var states = GetRandomStates();
            const int days = 5;

            // Act
            var newStates = houses.CellCompete(states, days);

            // Assert
            Check.That(newStates.Length).IsNotEqualTo(0);
        }

        [TestCase(1,0,0,0,0,1,0,0)]
        public void TestCaseOne(params int[] initialStates)
        {
            // Arrange
            var expectedStates = new[] {0, 1, 0, 0, 1, 0, 1, 0};
            const int numberOfDays = 1;
            IEightHouses houses = new SourceProject.EightHouses.EightHouses();

            // Act
            var finalStates = houses.CellCompete(initialStates, numberOfDays);
            Check.That(finalStates).ContainsExactly(expectedStates);
        }

        [TestCase(1,1,1,0,1,1,1,1)]
        public void TestCaseTwo(params int[] initialStates)
        {
            // Arrange
            var expectedStates = new[] {0, 0, 0, 0, 0, 1, 1, 0};
            const int numberOfDays = 2;
            IEightHouses houses = new SourceProject.EightHouses.EightHouses();

            // Act
            var finalStates = houses.CellCompete(initialStates, numberOfDays);
            Check.That(finalStates).ContainsExactly(expectedStates);
        }

        private static int[] GetRandomStates()
        {
            var states = new State[8];
            var random = new Random();
            for (var i = 0; i < 8; i++)
            {
                var number = random.Next(0, 2);
                states[i] = (State) number;
            }

            var statesAsInt = states.Select(state => (int) state).ToArray();
            return statesAsInt;
        }
    }
}