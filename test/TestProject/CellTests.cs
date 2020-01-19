using NFluent;
using NUnit.Framework;
using SourceProject;

namespace TestProject
{
    public class CellTests
    {
        [TestCase(State.Inactive)]
        [TestCase(State.Active)]
        public void ShouldReturnInactive_WhenBothNeighborsHaveTheSameStatus(int upperCellState)
        {
            // Arrange
            var upperCell = new Cell(upperCellState);
            var lowerCell = new Cell(upperCellState);
            var cell = new Cell(State.Unknown)
            {
                UpperCell = upperCell,
                LowerCell = lowerCell
            };

            // Act
            cell.SetNextDayState();

            // Assert
            Check.That(cell.NextDayState).IsEqualTo(State.Inactive);
        }
    }
}