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
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("1");
                Environment.Exit(0);
            }
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int x = UserProgramCode.findMaxSpan(a);
            Console.WriteLine(x);
        }
    }
    class UserProgramCode
    {
        public static int findMaxSpan(int[] a)
        {
            int k = 0;
            int flag = 0;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=a.Length-1;j>i;j--)
                {
                    if(a[i]==a[j])
                    {
                        flag = 1;
                        k = (j - i) + 1;
                        break;
                    }
                }
                if (flag == 1)
                    break;
            }
            if (flag == 0)
            {
                return -1;
            }
            else
                return k;
        }
    }
}
