using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    class Worker
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        public void doWork(int hours, WorkType work)
        {
            public event WorkPerformedHandler WorkPerformed;
            public event EventHandler WorkCompleted;

        }
    }
}
