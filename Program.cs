using System;

namespace DelegatesAndEvents
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Worker worker = new Worker();
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_WorkPerformed);
            worker.WorkCompleted += new EventHandler(worker_WorkCompleted);
            worker.DoWork(05, WorkType.GoToMeetings);
            
        }

        private static void worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work Completed");
        }

        private static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Hours Worked-"+e.Hours+"WorkType-"+e.WorkType);
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerareReports
    }

}
