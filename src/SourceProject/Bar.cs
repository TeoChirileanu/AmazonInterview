namespace SourceProject
{
    public class Bar
    {
        /*
         2d grid of cell towers
         0 = out of date
         1 = up to date
         on a single day, a server can push update to its neighbors
         neighbors are either left, right, above or below
         once update, the server can push the notifications to its neighbors as well
         write an algorithm that will determine the minimum number of days required
         to push the update to all the available servers
         */
        public static int MinimumDays(int rows, int columns, int[,] grid)
        {
            // todo: validate rows and columns e.g. not to be negative or zero

            // todo: check for invalid numbers in grid

            var dayZeroServers = GetDayZeroServers(rows, columns, grid);

            return PushUpdatedUntilAllServersAreUpdated(rows, columns, dayZeroServers, 1);

            // todo: return -1 if the servers cannot be updated
        }

        private static Server[,] GetDayZeroServers(int rows, int columns, int[,] grid)
        {
            var dayZeroServers = new Server[rows, columns];

            // todo: initialize edges: [0,0] [0,columns-1] [rows-1,0] [rows-1,columns-1]

            // todo: initialize first row: [0,1]..[0,columns-1]

            // todo: initialize last row: [rows-1,1]..[rows-1,columns-1]

            // todo: initialize first column: [1,0]..[rows-1,0]

            // todo: initialize last column: [1,columns-1]..[rows-1,columns-1]

            // initialize inner
            for (var i = 1; i < rows - 1; i++)
            {
                for (var j = 1; j < columns - 1; j++)
                {
                    dayZeroServers[i, j] = new Server(
                        status: grid[i, j],
                        left: new Server(grid[i, j - 1]),
                        right: new Server(grid[i, j + 1]),
                        above: new Server(grid[i - 1, j]),
                        below: new Server(grid[i + 1, j]));
                }
            }

            return dayZeroServers;
        }

        private static int PushUpdatedUntilAllServersAreUpdated(int rows, int columns, Server[,] servers, int daysPassed)
        {
            if (AreAllServersUpdated(rows, columns, servers)) return daysPassed;

            var dayNServers = new Server[rows, columns];

            // todo: get next day status for edges: [0,0] [0,columns-1] [rows-1,0] [rows-1,columns-1]

            // todo: get next day status for first row: [0,1]..[0,columns-1]

            // todo: get next day status for last row: [rows-1,1]..[rows-1,columns-1]

            // todo: get next day status for first column: [1,0]..[rows-1,0]

            // todo: get next day status for last column: [1,columns-1]..[rows-1,columns-1]

            // get next day status for inner
            for (var i = 1; i < rows - 1; i++)
            {
                for (var j = 1; j < columns - 1; j++)
                {
                    dayNServers[i, j] = new Server(
                        status: servers[i, j].NextDayStatus(),
                        left: new Server(servers[i, j - 1].NextDayStatus()),
                        right: new Server(servers[i, j + 1].NextDayStatus()),
                        above: new Server(servers[i - 1, j].NextDayStatus()),
                        below: new Server(servers[i + 1, j].NextDayStatus()));
                }
            }

            return PushUpdatedUntilAllServersAreUpdated(rows, columns, dayNServers, daysPassed + 1);
        }

        private static bool AreAllServersUpdated(int rows, int columns, Server[,] servers)
        {
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    if (servers[i, j].Status() == 0) return false;
                }
            }

            return true;
        }
    }
}