using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = UserProgramCode.getMonthday(s, b);
            Console.WriteLine(x);
        }
    }
    class UserProgramCode
    {
        public static int getMonthday(int a,int b)
        {
            int d = System.DateTime.DaysInMonth(a, b + 1);
            return d;
        }
    }
}
