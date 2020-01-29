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

        public int GetNextDayState()
        {
            var isLowerActive = _left?._state == 1;
            var isUpperActive = _right?._state == 1;
            var areNeighborsActive = isLowerActive & isUpperActive;

            var isLowerInactive = _left?._state == 0;
            var isUpperInactive = _right?._state == 0;
            var areNeighborsInactive = isLowerInactive & isUpperInactive;

            var doNeighborsHaveSameState = areNeighborsActive & areNeighborsInactive;
            return doNeighborsHaveSameState ? 0 : 1;
        }
    }
}