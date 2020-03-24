using System;

namespace DelegatesAndEvents
{
    class Program
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);

            del1(05, WorkType.Golf);
            del2(01, WorkType.GenerareReports);

            Console.ReadLine();

        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Performed1 called");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Performed2 called");
        }

    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerareReports
    }

}
