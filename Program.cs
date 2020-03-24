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
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);
            del1 += del2 + del3;
            doWork(del1);

            Console.ReadLine();

        }
        static void doWork(WorkPerformedHandler del)
        {
            del(05, WorkType.Golf);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Performed1 called "+hours.ToString());
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Performed2 called "+ hours.ToString());
        }

        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"Work Performed3 called " + hours.ToString());
        }

    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerareReports
    }

}
