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
            int x = UserProgramCode.getDigits(s);
            Console.WriteLine(x);
        }
    }
    class UserProgramCode
    {
        public static int getDigits(string s)
        {
            int sum = 0;
            int flag = 0;
            s = s.ToLower();
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] >= 97 & s[i] <= 122 | s[i] >= 48 & s[i] <= 57)
                {
                    if (s[i] >= 48 & s[i] <= 57)
                    {
                        sum = sum + (s[i] - 48);
                        flag = 1;
                    }
                }
                else
                    return -1;
            }
            if (flag == 0)
                return -2;
            else
                return sum;
            
        }
    }
}
