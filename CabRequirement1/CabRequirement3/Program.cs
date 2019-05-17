using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRequirement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the registration number to be validated:");
            string s = Console.ReadLine();
            bool b = Customer.ValidRegistrationNumber(s);
            if(b==true)
            {
                Console.WriteLine("Registration Number is Valid");
            }
            else
            {
                Console.WriteLine("Registration Number is InValid");
            }
        }
    }
}
