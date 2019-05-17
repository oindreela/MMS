using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRequirement5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> x = new List<string>();
            List<Customer> b = new List<Customer>();

            Console.WriteLine("Enter the number of customer:");
            int a = int.Parse(Console.ReadLine());
            for(int i=0;i<a;i++)
            {
                Console.WriteLine("Enter the customer {0} Details:",(i+1));
                string s1 = Console.ReadLine();
                x.Add(s1);
            }
            b = Customer.PopulateCustomers(x);
            foreach(Customer z in b)
            {
                Console.WriteLine(z.Id +"," +z.Name+","+z.Gender+","+z.Email + "," + z.ContactNumber + "," + z.CreatedOn.ToString());
            }
            List<Customer> c = new List<Customer>();
            Console.WriteLine("Enter the substring from customer list:");
            string s = Console.ReadLine();
            c = Customer.FindCustomerNameFromList(b, s);
            foreach(Customer v in c)
            {
                Console.WriteLine(v.Id + "," + v.Name + "," + v.Gender + "," + v.Email + "," + v.ContactNumber + "," + v.CreatedOn.ToString());

            }
        }
    }
}
