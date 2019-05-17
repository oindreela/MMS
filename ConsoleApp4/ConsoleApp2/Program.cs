using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool b = UserProgramCode.validateNumber(str);
            if (b == true)
                Console.WriteLine("Valid Number");
            else
                Console.WriteLine("Invalid Number");
        }
    }
    class UserProgramCode
    {
        public static bool validateNumber(string s)
        {
            string pattern = @"^\d{3}-\d{3}-\d{4}$";
            return  Regex.IsMatch(s, pattern);
        }
    }
}
