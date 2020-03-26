using System;

namespace DelegatesAndEvents
{
    public class Program
    {
        public delegate int BizRulesDelegate(int x, int y);
            

        static void Main(string[] args)
        {
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate mulDel = (x, y) => x * y;

             var data = new ProcessData();
            data.Process(2,3, addDel);
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
