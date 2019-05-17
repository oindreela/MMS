using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int flag = 0;
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] > 500)
                    flag = 1;
            }

            if (flag == 1)
            {
                Console.WriteLine("Array element greater than 500");
                Environment.Exit(0);
            }
           int[] res= UserProgramCode.getAllElement(a);
            for(int i=0;i<res.Length & res[i]!=0;i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
    class UserProgramCode
    {
        public static int[] getAllElement(int[] a)
        {
            int x = a.Length;
            int[] c = new int[20];
            int k = 0;
            for(int i=0;i<x;i++)
            {
                if(a[i]>5)
                {
                    c[k] = a[i];
                    ++k;
                }
            }
            return c;
            
        }
    }

}
