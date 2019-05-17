using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockQuestion1
{
    class UserProgramCode
    {
        public static int FindRange(int[] b)
        {
            int a = b.Max();
            int c = b.Min();
            int d = Math.Abs(a - c);
            return d;
        }
    }
}
