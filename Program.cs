using System;

namespace DelegatesAndEvents
{
    class Program
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerareReports
    }

}
