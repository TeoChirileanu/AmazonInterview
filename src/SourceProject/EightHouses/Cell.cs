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
            var isLowerActive = _lowerCell?._currentState == State.Active;
            var isUpperActive = _upperCell?._currentState == State.Active;
            var areNeighborsActive = isLowerActive & isUpperActive;

            var isLowerInactive = _lowerCell?._currentState == State.Inactive;
            var isUpperInactive = _upperCell?._currentState == State.Inactive;
            var areNeighborsInactive = isLowerInactive & isUpperInactive;

            var doNeighborsHaveSameState = areNeighborsActive & areNeighborsInactive;
            return doNeighborsHaveSameState ? State.Inactive : State.Active;
            //var lowerCellState = Convert.ToBoolean(_lowerCell?._currentState);
            //var upperCellState = Convert.ToBoolean(_upperCell?._currentState);
            //var haveDifferentStates = lowerCellState ^ upperCellState;
            //return haveDifferentStates ? State.Active : State.Ina
        }
    }
}