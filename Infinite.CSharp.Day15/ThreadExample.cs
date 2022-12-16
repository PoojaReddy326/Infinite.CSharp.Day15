using System;
using System.Threading;



namespace Infinite.CSharp.Day16
{
    class ThreadExample
    {
        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method 1 = {i}");
                Thread.Sleep(1000);
            }
        }
        public static void Method2()
        {
            for (int i = 101; i < 110; i++)
            {
                Console.WriteLine($"Method 2 = {i}");
                Thread.Sleep(1000);
            }
        }
        public static void FirstMethod()
        {
            Console.WriteLine($"First method before sleep :{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"First method after sleep :{Thread.CurrentThread.ManagedThreadId}");
        }



        public static void SecondMethod()
        {
            Console.WriteLine($"Second method before sleep :{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Second method after sleep :{Thread.CurrentThread.ManagedThreadId}");
        }



        public static void ThirdMethod()
        {
            Console.WriteLine($"Third method before sleep :{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000);
            Console.WriteLine($"Third method after sleep :{Thread.CurrentThread.ManagedThreadId}");
        }



        public static void FourthMethod()
        {
            Console.WriteLine($"Fourth method before sleep :{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine($"Fourth method after sleep :{Thread.CurrentThread.ManagedThreadId}");
        }

        static void Main1(string[] args)
        {
            //ThreadExample obj = new ThreadExample();
            //Unstarted State
            //ThreadStart ts1 = new ThreadStart(Method1);
            //Thread t1 = new Thread(ts1);
            //Thread t2 = new Thread(new ThreadStart(Method2));

            ////Started State
            //t1.Start();
            //t2.Start();

            Thread t1 = new Thread(new ThreadStart(FirstMethod));
            Thread t2 = new Thread(new ThreadStart(SecondMethod));
            Thread t3 = new Thread(new ThreadStart(ThirdMethod));
            Thread t4 = new Thread(new ThreadStart(FourthMethod));
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

        }
    }
}