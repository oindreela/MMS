using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mock_7_Req_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
            Console.WriteLine("1.Validate Age\n2.Validate Name\n3.Lucky Customer\nEnter Your Choice");
            int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter BirthDate:");
                        DateTime x = DateTime.Parse(Console.ReadLine());
                        bool b = ValidateAge(x);
                        if (b == true)
                            Console.WriteLine("Age is valid");
                        else
                            Console.WriteLine("Age is invalid");
                        Environment.Exit(0);
                        break;
                    case 2:
                        Console.WriteLine("Enter Name:");
                        bool d = ValidateName(Console.ReadLine());
                        if (d == true)
                            Console.WriteLine("Name is valid");
                        else
                            Console.WriteLine("Name is invalid");
                        Environment.Exit(0);
                        break;
                    case 3:
                        Console.WriteLine("Enter Mobile Number:");
                        string s = Console.ReadLine();
                        bool z = ValidateLuckyCustomer(s);
                        if (z == true)
                            Console.WriteLine("Lucky Customer");
                        else
                            Console.WriteLine("Unlucky Customer");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        Environment.Exit(0);
                        break;
                }

            }


           
        }
        static bool ValidateAge(DateTime birth)
        {
            
            DateTime currentDate = DateTime.ParseExact("01-01-2018", "dd-MM-yyyy", null);
            int years = ((TimeSpan)(currentDate-birth)).Days;
            years = years / 365;
            return years >= 18 ? true : false;
        }
        static bool ValidateName(string name)
        {
            string pattern = @"^[A-Za-z]+$";
            bool b = Regex.IsMatch(name, pattern);
            return b;

        }
        static bool ValidateLuckyCustomer(string mobile)
        {
            long num = Convert.ToInt64(mobile);
            long sum = 0;
            while(num>0)
            {
                long rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            long sum1 = 0;
            if (sum == 1)
                return true;
        
                while (sum > 0)
                {
                    long rem1 = sum % 10;
                    sum1 = sum1 + rem1;
                    sum = sum / 10;
                }
            if (sum1 == 1)
                return true;
            long sum2 = 0;
            while (sum1 > 0)
            {
                long rem1 = sum1 % 10;
                sum2 = sum2 + rem1;
                sum1 = sum1 / 10;
            }
            if (sum2 == 1)
                return true;
            else
                return false;


        }
    }
}
