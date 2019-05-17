using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRequirement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            Console.WriteLine("Enter customer 1 details:");
            string s = Console.ReadLine();
            string[] a = s.Split(',');
            c = new Customer(a[0], a[1], a[2], a[3]);

            Customer c1 = new Customer();
            Console.WriteLine("Enter customer 2 details:");
            string s1 = Console.ReadLine();
            string[] a1 = s1.Split(',');
            c1 = new Customer(a1[0], a1[1], a1[2], a1[3]);

            Console.WriteLine();
            Console.WriteLine("Customer 1");
            Console.WriteLine(c);
            Console.WriteLine();

            //Console.WriteLine();
            Console.WriteLine("Customer 2");
            Console.WriteLine(c1);
            Console.WriteLine();

            if(c.Equals(c1))
            {
                Console.WriteLine("Customer 1 is same as Customer 2");
            }
            else
            {
                Console.WriteLine("Customer 1 and Customer 2 are different");
            }
        }
    }
}
