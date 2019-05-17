using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int[] a = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int n2 = int.Parse(Console.ReadLine());
            int[] b = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            UserProgramCode.FindDifference(a, b);
         
        }
    }
    class UserProgramCode
    {
        public static void FindDifference(int[] a, int[] b)
        {
            int x = a.Length;
            int y = b.Length;
            int k = 0;
            int[] c = new int[20];
            int flag = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    flag = 0;
                    if(a[i]==b[j])
                    {
                        flag = 1;
                        break;
                    }
                   
                }
                if (flag == 0)
                {
                    c[k] = a[i];
                    ++k;
                }
            }
           
          
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(c[i]);
            }

        }
    }
}