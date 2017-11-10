using System;
using System.Threading;

namespace Prep_Exam_70_483.Chapter1
{
    public static class List_1_1
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine("Thread: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Main()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work");
                Thread.Sleep(0);
            }

            thread.Join();
        }
    }
}
