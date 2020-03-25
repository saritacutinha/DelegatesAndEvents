using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
  //public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);
   public  class Worker
    {      
        
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType work)
        {
            for(int i=0; i< hours; i++)
            {
                OnWorkPerformed(i + 1, work);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType work)
        {
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if(del!=null)
            {
                del(this, new WorkPerformedEventArgs(hours, work));
            }

        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }

        }
    }
}
