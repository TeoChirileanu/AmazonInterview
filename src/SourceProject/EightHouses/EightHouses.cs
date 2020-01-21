using System.Collections.Generic;

namespace SourceProject.EightHouses
{
    public class EightHouses
    {
        private readonly Cell[] _cells = new Cell[8];

        public State[] GetStatesAfterGivenDays(State[] states, int numberOfDays)
        {
            InitialiseFirstCell(states);
            InitialiseOtherCells(states);
            InitialiseLastCell(states);

            return GetNextDayStates(numberOfDays);
        }

        private State[] GetNextDayStates(int numberOfDays)
        {
            var newStates = new State[8];

            for (var i = 0; i < numberOfDays; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    newStates[j] = _cells[j].GetNextDayState();
                }
            }

            return newStates;
        }

        private void InitialiseOtherCells(IReadOnlyList<State> states)
        {
            for (var i = 1; i < 7; i++)
            {
                _cells[i] = new Cell(states[i],
                    new Cell(states[i - 1]),
                    new Cell(states[i + 1]));
            }
        }

        private void InitialiseFirstCell(IReadOnlyList<State> states)
        {
            _cells[0] = new Cell(states[0],
                new Cell(State.Inactive),
                new Cell(states[1]));
        }

        private void InitialiseLastCell(IReadOnlyList<State> states)
        {
            _cells[7] = new Cell(states[7],
                new Cell(states[6]),
                new Cell(State.Inactive));
        }
    }
}