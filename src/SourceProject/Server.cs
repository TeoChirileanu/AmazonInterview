namespace SourceProject
{
    public class Server
    {
        private readonly Server _above;
        private readonly Server _below;

        private readonly Server _left;

        private readonly Server _right;

        // 0 for out of date, 1 for up to date
        private readonly int _status;

        public Server(int status,
            Server left = null, Server right = null,
            Server above = null, Server below = null)
        {
            _status = status;

            _left = left;
            _right = right;
            _above = above;
            _below = below;
        }

        public int Status() => _status;

        public int NextDayStatus()
        {
            return _left?._status == 1 ||
                   _right?._status == 1 ||
                   _above?._status == 1 ||
                   _below?._status == 1
                ? 1
                : 0;
        }
    }
}