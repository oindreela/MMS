using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketRequirement1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Seat 1 Details:");
            string str1 = Console.ReadLine();
            string[] s = str1.Split(',');
            Seat s1 = new Seat(int.Parse(s[0]),s[1],double.Parse(s[2]),s[3],s[4]);

            Console.WriteLine();

            Console.WriteLine("Enter Seat 2 Details:");
            string str2 = Console.ReadLine();
            string[] s2 = str2.Split(',');
            Seat s3 = new Seat(int.Parse(s2[0]), s2[1], double.Parse(s2[2]), s2[3], s2[4]);
            Console.WriteLine();

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s3);
            bool b = s1.Equals(s3);
            if(b)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("different");
            }


        }
    }
}
