using NFluent;
using NUnit.Framework;
using SourceProject;

namespace TestProject
{
    public class CellTests
    {
        [TestCase(State.Inactive)]
        [TestCase(State.Active)]
        public void ShouldReturnInactive_WhenBothNeighborsHaveTheSameStatus(State state)
        {
            // Arrange
            var upperCell = new Cell(state);
            var lowerCell = new Cell(state);
            var cell = new Cell(default, lowerCell, upperCell);

            // Act
            var nextDayState = cell.GetNextDayState();

            // Assert
            Check.That(nextDayState).IsEqualTo(State.Inactive);
        }
    }
}