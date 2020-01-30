using System;

namespace SourceProject.EightHouses
{
    public class House
    {
        private readonly int _state; // 0 = Inactive, 1 = Active
        private readonly House _left;
        private readonly House _right;

        public House()
        {
            _state = 0;
            _left = null;
            _right = null;
        }

        public House(int state)
        {
            _state = state;
            _left = null;
            _right = null;
        }

        public House(int state, House left, House right)
        {
            _state = state;
            _left = left;
            _right = right;
        }

        public int GetCurrentDayState() => _state;

        public int GetNextDayState() => Convert.ToInt32(
                Convert.ToBoolean(_left?._state) ^ Convert.ToBoolean(_right?._state));
    }
}