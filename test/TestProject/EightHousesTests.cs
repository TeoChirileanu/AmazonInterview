using System;
using System.Linq;
using NFluent;
using NUnit.Framework;
using SourceProject;

namespace TestProject
{
    public class EightHousesTests
    {
        [Test]
        public void ShouldReturnAnArrayWithStates()
        {
            // Arrange
            var houses = new EightHouses();
            var states = GetRandomStates();
            const int days = 5;

            // Act
            var newStates = houses.GetStatesAfterGivenDays(states, days);
            var newStatesAsIntArray = newStates.Select(s => (int) s).ToArray();

            // Assert
            Check.That(newStates.Length).IsNotEqualTo(0);
            Check.That(newStatesAsIntArray.Length).IsNotEqualTo(0);
        }

        private static State[] GetRandomStates()
        {
            var states = new State[8];
            var random = new Random();
            for (var i = 0; i < 8; i++)
            {
                var number = random.Next(0, 2);
                states[i] = (State) number;
            }
            return states;
        }
    }
}