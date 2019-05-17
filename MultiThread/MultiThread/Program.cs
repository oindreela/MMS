using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(work1);
            Thread thread2 = new Thread(work2);
            
            thread1.Start();
            //thread1.Join();
            thread2.Start();
            thread2.Name = "T2";
            thread1.Name = "T1";
            thread2.IsBackground = true;
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Lowest;
            //thread2.Join();
            Console.WriteLine("End of thread");
        }
        static void work1()
        {
            //for(int i=0;i<=5;i++)
            //{
            //    Console.WriteLine("Work 1 is called:" + i.ToString());
            //}
            //Thread.Sleep(5000);
            //for (int i = 6; i <= 10; i++)
            //{
            //    Console.WriteLine("Work 1 is called:" + i.ToString());
            //}
            Console.WriteLine("Work 1:"+Thread.CurrentThread.Name);
            Thread.Sleep(1000);
            Console.WriteLine("Work 1..");
            Thread.Sleep(1000);
        }
        static void work2()
        {
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Work 2 is called:" + i.ToString());
            //}
            //Thread.Sleep(5000);
            //for (int i = 6; i <= 10; i++)
            //{
            //    Console.WriteLine("Work 2 is called:" + i.ToString());
            //}
            Console.WriteLine("Work 2");
            Thread.Sleep(1000);
            Console.WriteLine("Work 2..");
            Thread.Sleep(1000);
        }
    }
}
