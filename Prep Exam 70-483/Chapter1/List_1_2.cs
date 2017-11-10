using System;
using System.Threading;

namespace Prep_Exam_70_483.Chapter1
{
    public static class List_1_2
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.IsBackground = true;//true = exits immediatly / false = prints ThreadMethod
            thread.Start();
        }
    }
}
