using System;
using System.Collections.Generic;
using System.Linq;

namespace SourceProject.EightHouses
{
    public class EightHouses : IEightHouses
    {
        public int[] CellCompete(int[] states, int days)
        {
            var statesAsEnum = states.Select(i => (State) i).ToArray();

            var cells = new Cell[8];

            cells[0] = new Cell(statesAsEnum[0],
                new Cell(State.Inactive),
                new Cell(statesAsEnum[1]));

            for (var i = 1; i < 7; i++)
            {
                cells[i] = new Cell(statesAsEnum[i],
                    new Cell(statesAsEnum[i - 1]),
                    new Cell(statesAsEnum[i + 1]));
            }

            cells[7] = new Cell(statesAsEnum[7],
                new Cell(statesAsEnum[6]),
                new Cell(State.Inactive));

            var newStates = new State[8];
            for (var i = 0; i <= days; i++)
            {
                var newStatesAfterDayX = GetNextDayStates(cells);
                Array.Copy(newStatesAfterDayX, newStates, 8);
            }

            return newStates.Select(state => (int)state).ToArray();
        }

        private static State[] GetNextDayStates(IReadOnlyList<Cell> cells)
        {
            var newStates = new State[8];
            for (var j = 0; j < 8; j++)
            {
                newStates[j] = cells[j].GetNextDayState();
            }
            return newStates;
        }
    }
}