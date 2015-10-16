using System;
using System.Threading;

namespace Multithread.SimpleCounter
{
    class SimpleCounter
    {
        private static void Run()
        {
            Run(false);
        }

        private static void Run(bool sleep)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("RUN - {0}, SLEEP - {1}", i, sleep);

                if (sleep)
                    Thread.Sleep(10);
            }
        }
        private static void Run(object sleep)
        {
            Run(Convert.ToBoolean(sleep));
        }
        private static void RunTwice()
        {
            RunTwice(false);
        }
        private static void RunTwice(bool sleep)
        {
            for (int i = 0; i < 20; i = i + 2)
            {
                Console.WriteLine("RUN TWICE - {0}, SLEEP - {1}", i, sleep);

                if (sleep)
                    Thread.Sleep(10);
            }
           
        }

        public static void TestRun()
        {
            Console.WriteLine("Test Running Counter against Thread");

            Thread t1 = new Thread(new ThreadStart(SimpleCounter.Run));
            Thread t2 = new Thread(new ThreadStart(SimpleCounter.RunTwice));

            t1.Start();
            t2.Start();
        }
        public static void TestRunWithSleep()
        {
            Console.WriteLine("Test Running Counter against Thread with sleep");

            //Thread t1 = new Thread(() => Run(true));
            Thread t1 = new Thread(new ParameterizedThreadStart(SimpleCounter.Run));
            Thread t2 = new Thread(() => SimpleCounter.RunTwice(true));

            t1.Start(true);
            t2.Start();
        }
    }
}
