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
            data.Process(2, 3, addDel);

            //Action<int, int> myAction = (x, y) => Console.WriteLine(x + y); 
            //Action<int, int> myMulAction = (x, y) => Console.WriteLine(x * y);
            //data.processAction(2, 3, myAction);

            Func<int, int, int> funcAdd = (x, y) => x + y;
            Func<int, int, int> funcMul = (x, y) => x * y;
            data.processFunc(2, 3, funcMul);
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
