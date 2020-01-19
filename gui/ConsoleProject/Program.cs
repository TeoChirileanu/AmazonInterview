using System;
using SourceProject;

namespace ConsoleProject
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Executing...");
            var _ = new Cell(State.Unknown);
            Console.WriteLine("Success!");
        }
    }
}
