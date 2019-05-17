using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRequirement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product 1 Details:");
            string str = Console.ReadLine();
            string[] str1 = str.Split(',');
            Product p1 = new Product(str1[0], str1[1], str1[2], int.Parse(str1[3]), double.Parse(str1[4]), DateTime.Parse(str1[5]));

            Console.WriteLine("Enter Product 2 Details:");
            string str2 = Console.ReadLine();
            string[] str3 = str2.Split(',');
            Product p2 = new Product(str3[0], str3[1], str3[2], int.Parse(str3[3]), double.Parse(str3[4]), DateTime.Parse(str3[5]));

            Console.WriteLine();
            Console.WriteLine("Product 1\n");
            Console.WriteLine(p1+"\n");
            Console.WriteLine("Product 1\n");
            Console.WriteLine(p2);
            Console.WriteLine();
            bool b = p1.Equals(p2);
            if (b)
                Console.WriteLine("Product1 and Product2 are same");
            else
                Console.WriteLine("Product1 and Product2 are different");
        }
    }
}
