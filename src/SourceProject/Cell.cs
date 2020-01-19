namespace SourceProject
{
    public class Cell
    {
        private int _currentState;
        private int _nextDayState;

        public Cell(int currentState)
        {
            _currentState = currentState;
        }

        public int NextDayState
        {
            get => _nextDayState;
            private set
            {
                _currentState = _nextDayState;
                _nextDayState = value;
            }
        }

        public Cell UpperCell { private get; set; }
        public Cell LowerCell { private get; set; }

        public void SetNextDayState()
        {
            // this should be an XOR
            if (UpperCell._currentState == State.Active && LowerCell._currentState == State.Active)
            {
                NextDayState = State.Inactive;
                return;
            }

            if (UpperCell._currentState == State.Inactive && LowerCell._currentState == State.Inactive)
            {
                NextDayState = State.Inactive;
                return;
            }

            NextDayState = State.Active;
        }
    }
}