using System.Collections.Generic;
using System.Linq;

namespace SourceProject.EightHouses
{
    public static class Houses
    {
        public static int[] Compete(int[] states, int days)
        {
            var dayZeroHouses = GetDayZeroHouses(states);

            var dayNHouses = GetDayNHouses(dayZeroHouses, days);

            var finalStates = dayNHouses
                .Select(house => house.GetCurrentDayState())
                .ToArray();

            return finalStates;
        }

        private static House[] GetDayZeroHouses(IReadOnlyList<int> states)
        {
            var dayZeroHouses = new House[8];

            dayZeroHouses[0] = new House(
                states[0],
                new House(),
                new House(states[1]));

            dayZeroHouses[7] = new House(
                states[7],
                new House(states[6]),
                new House());

            for (var i = 1; i < 7; i++)
                dayZeroHouses[i] = new House(
                    states[i],
                    new House(states[i - 1]),
                    new House(states[i + 1]));
            return dayZeroHouses;
        }

        private static House[] GetDayNHouses(House[] dayNMinusOneHouses, int numberOfDaysRemaining)
        {
            if (numberOfDaysRemaining < 0) return new House[0];
            if (dayNMinusOneHouses.Length != 8) return new House[0];

            if (numberOfDaysRemaining == 0) return dayNMinusOneHouses;

            var dayNHouses = new House[8];

            dayNHouses[0] = new House(
                dayNMinusOneHouses[0].GetNextDayState(),
                new House(),
                new House(dayNMinusOneHouses[1].GetNextDayState()));

            dayNHouses[7] = new House(
                dayNMinusOneHouses[0].GetNextDayState(),
                new House(dayNMinusOneHouses[6].GetNextDayState()),
                new House());

            for (var i = 1; i < 7; i++)
                dayNHouses[i] = new House(
                    dayNMinusOneHouses[i].GetNextDayState(),
                    new House(dayNMinusOneHouses[i - 1].GetNextDayState()),
                    new House(dayNMinusOneHouses[i + 1].GetNextDayState()));

            return GetDayNHouses(dayNHouses, numberOfDaysRemaining - 1);
        }
    }
}