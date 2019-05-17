using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMOFODD
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(UserProgramCode.AddOdd(a, n));
        }
    }
    class UserProgramCode
    {
        public static int AddOdd(int[] a,int n)
        {
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                if (a[i] % 2 != 0)
                    sum += a[i];
            }
            return sum;
        }
    }
}
