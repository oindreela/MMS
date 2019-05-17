using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace pract
{
    class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Question1);
            Thread t2 = new Thread(Question2);
            Thread t3 = new Thread(Question3);
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();
            Console.WriteLine("Your Score is: " + score);
        }
        static void Question1()
        {
            Console.WriteLine("Q1.Who is CEO of CTS?");
            Console.WriteLine("1.Bill gates 2.Jeff 3.None of Above 4.D'souza");
            int ans = int.Parse(Console.ReadLine());
            if (ans == 4)
                score += 10;
            else
                score = 0;
            Thread.Sleep(1000);
        }
        static void Question2()
        {
            Console.WriteLine("Q2.Which app is used for file sharing?");
            Console.WriteLine("1.Whatsapp 2.FaceBook 3.shareit 4.None of Above");
            int ans = int.Parse(Console.ReadLine());
            if (ans == 3)
                score += 10;
            else
                score = 0;
            Thread.Sleep(1000);
        }
        static void Question3()
        {
            Console.WriteLine("Q1.Who is founder of CTS?");
            Console.WriteLine("1.Bill gates 2.Jeff 3.None of Above 4.D'souza");
            int ans = int.Parse(Console.ReadLine());
            if (ans == 4)
                score += 10;
            else
                score = 0;
            Thread.Sleep(1000);
        }
    }
}
