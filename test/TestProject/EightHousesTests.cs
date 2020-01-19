using System.Runtime.InteropServices.ComTypes;
using NFluent;
using NUnit.Framework;
using SourceProject;

namespace TestProject
{
    public class EightHousesTests
    {
        [Test]
        public void ShouldDoSomething()
        {
            // Arrange
            var houses = new EightHouses();

            // Act
            int[] states = 
                {State.Active, State.Inactive, State.Inactive, State.Inactive, 
                    State.Inactive, State.Inactive, State.Inactive, State.Active};
            int days = 5;
            var newStates = houses.GetStatesAfterGivenDays(states, days);

            // Assert
            Check.That(newStates.Length).IsNotEqualTo(0);
        }
    }
}