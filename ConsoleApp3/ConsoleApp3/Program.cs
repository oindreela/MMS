using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char a = char.Parse(Console.ReadLine());
            
            int x = UserProgramCode.FindOccurance(s,a);
            if (x == -1)
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine(x);
        }
    }
    class UserProgramCode
    {
        public static int FindOccurance(string s,char a)
        {
            int count = 0;
            int x = s.Length;
            s = s.ToLower();
            for (int i = 0; i < x; i++)
            {
                if (s[i] >= 97 &&s[i] <= 122 || s[i] == ' ')
                {
                    if (a ==s[i])
                    {
                        count++;
                    }
                }
                else
                    return -1;
            }
            return count;
            

        }
    }
}
