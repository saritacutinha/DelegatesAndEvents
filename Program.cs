using System;

namespace DelegatesAndEvents
{
    class Program
    {

        static void Main(string[] args)
        {

            Worker worker = new Worker();
            //worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
            //                        {
            //                            Console.WriteLine($"Hours Worked-" + e.Hours + "WorkType-" + e.WorkType);
            //                        };

            worker.WorkPerformed += (s, e) => Console.WriteLine($"Hours Worked-" + e.Hours + "WorkType-" + e.WorkType);
            worker.WorkCompleted += worker_WorkCompleted;
            worker.DoWork(05, WorkType.GoToMeetings);

        }

        
        private static void worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work Completed");
        }
    }


        public enum WorkType
        {
            GoToMeetings,
            Golf,
            GenerareReports
        }

    }
