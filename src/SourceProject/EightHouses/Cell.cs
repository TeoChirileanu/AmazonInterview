using System;

namespace SourceProject.EightHouses
{
    public class Cell
    {
        private readonly State _currentState;
        private readonly Cell _lowerCell;
        private readonly Cell _upperCell;

        public Cell(State currentState, Cell lowerCell = null, Cell upperCell = null)
        {
            _currentState = currentState;
            _lowerCell = lowerCell;
            _upperCell = upperCell;
        }

        public State GetNextDayState()
        {
            var lowerCellState = Convert.ToBoolean(_lowerCell?._currentState);
            var upperCellState = Convert.ToBoolean(_upperCell?._currentState);
            var haveDifferentStates = lowerCellState ^ upperCellState;
            return haveDifferentStates ? State.Active : State.Inactive;
        }
    }
}