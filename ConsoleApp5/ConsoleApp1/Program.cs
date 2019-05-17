using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int x=UserProgramCode.countSequentialChar(s);
            Console.WriteLine(x);
        }
    }
    class UserProgramCode
    {
        public static int countSequentialChar(string s)
        {
            int x = s.Length;
            s = s.ToLower();
            string[] a = new string[x];
            int count = 0;
            for(int i=0;i<x-2;i++)
            {
                if (s[i] == s[i + 1] & s[i]==s[i+2])
                    count++; 
            }
            if (count== 0)
                return -1;
            else
                return count;
        }
    }
}
