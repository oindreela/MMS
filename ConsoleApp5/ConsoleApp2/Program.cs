using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int flag = 1;
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] < 0)
                    flag = 0;
                
            }
            int x = UserProgramCode.countOddInteger(a);
            
            if (flag == 0)
                Console.WriteLine("The Array consists non-positive value(s)");
            else
                Console.WriteLine(x);
        }

    }
    class UserProgramCode
    {
        public static int countOddInteger(int[] a)
        {
            int n = a.Length;
            int count = 0;
            for(int i=0;i<n;i++)
            {
                if(a[i]%2!=0)
                {
                    count++;
                }
            }
            if (count == 0)
                return -1;
            else
                return count;
        }
    }
}
