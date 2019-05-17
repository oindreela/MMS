using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           string x= UserProgramCode.checkStrongNumber(n);
            Console.WriteLine(x);
        }
    }
    class UserProgramCode
    {
        public static string checkStrongNumber(int n)
        {
            int temp = n,sum=0,fact=1,rem;
            if(temp<0)
            {
                string s = "Invalid Input";
                return s;
            }
            while(temp>0)
            {
                rem = temp % 10;
                fact = 1;
                for(int i=rem;i>0;i--)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                temp = temp / 10;
            }
            if(n==sum)
            {
                string s = string.Format("{0} is a Strong Number", n);
                return s;
            }
            else
            {
                string s = string.Format("Sum of all digits factorial is {0}", sum);
                return s;

            }
        }
    }
}
