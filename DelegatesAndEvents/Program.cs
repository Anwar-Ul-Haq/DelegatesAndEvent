using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    class Program
    {
        static void Main(string[] args)
        {
            //var del1 = new WorkPerfromedHandler(WorkPerformed1);
            //var del2 = new WorkPerfromedHandler(WorkPerformed2);
            //var del3 = new WorkPerfromedHandler(WorkPerformed3);

            //del1 += del2 + del3;


            //del1(5, WorkType.GoToMeetings);

            var worker = new Worker();
            worker.WorkPerformed += worker_WorkPerformed;
            worker.WorkCompleted += worker_WorkCompleted;

            worker.DoWork(8,WorkType.Golf);


            Console.ReadLine();
           
        }

        private static void worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

        private static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours Worked " + e.Hours);
        }


        //public static void DoWork(WorkPerfromedHandler del)
        //{
        //    del(5, WorkType.GoToMeetings);
        //}
        //static void WorkPerformed1(int hours,WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed  1 was  calld");
        //}

        //static void WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed 3 was  calld");
        //}

        //static void WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed  2 was  calld");
        //}
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        Sleep
    }
}
