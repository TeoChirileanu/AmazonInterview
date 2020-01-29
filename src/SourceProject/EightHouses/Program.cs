namespace SourceProject.EightHouses
{
    public class Program
    {
        public static void CellCompete(int[] states, int days)
        {
            // day 0 (initial)
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

            // day 1
            var dayOneHouses = new House[8];

            dayOneHouses[0] = new House(
                dayZeroHouses[0].GetNextDayState(),
                new House(),
                new House(dayZeroHouses[1].GetNextDayState()));

            dayOneHouses[7] = new House(
                states[7],
                new House(dayZeroHouses[6].GetNextDayState()),
                new House());

            for (var i = 1; i < 7; i++)
                dayOneHouses[i] = new House(
                    dayZeroHouses[i].GetNextDayState(),
                    new House(dayZeroHouses[i - 1].GetNextDayState()),
                    new House(dayZeroHouses[i + 1].GetNextDayState()));

            // day 2
            var dayTwoHouses = new House[8];

            dayTwoHouses[0] = new House(
                dayOneHouses[0].GetNextDayState(),
                new House(),
                new House(dayOneHouses[1].GetNextDayState()));

            dayTwoHouses[7] = new House(
                states[7],
                new House(dayOneHouses[6].GetNextDayState()),
                new House());

            for (var i = 1; i < 7; i++)
                dayTwoHouses[i] = new House(
                    dayOneHouses[i].GetNextDayState(),
                    new House(dayOneHouses[i - 1].GetNextDayState()),
                    new House(dayOneHouses[i + 1].GetNextDayState()));
        }
    }
}