namespace SourceProject
{
    public class EightHouses
    {
        private readonly Cell[] _cells = new Cell[8];

        public int[] GetStatesAfterGivenDays(int[] states, int days)
        {
            var newStates = new int[8];

            _cells[0] = new Cell(states[0])
            {
                LowerCell = new Cell(State.Inactive),
                UpperCell = new Cell(states[1])
            };
            for (var i = 1; i < 7; i++)
            {
                _cells[i - 1] = new Cell(states[i - 1]);
                _cells[i] = new Cell(states[i]);
                _cells[i + 1] = new Cell(states[i + 1]);
            }

            _cells[7] = new Cell(states[7])
            {
                LowerCell = new Cell(states[6]),
                UpperCell = new Cell(State.Inactive)
            };

            for (var i = 0; i < days; i++)
            for (var j = 0; j < 8; j++)
            {
                _cells[i].SetNextDayState();
                newStates[i] = _cells[i].NextDayState;
            }

            return newStates;
        }
    }
}