using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockQuestion1
{
    class UserProgramCode
    {
        public static int FindPrimeSum(int s)
        {
            int count = 0,sum=0;
            for(int i=1;i<=s;i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    
                    if (i % j== 0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
