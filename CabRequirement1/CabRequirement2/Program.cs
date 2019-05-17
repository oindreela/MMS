using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRequirement2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cab> b= new List<Cab>();
            Console.WriteLine("Enter the number of cabs:");
            int a=int.Parse(Console.ReadLine());
            for(int i=0;i<a;i++)
            {
                string s = Console.ReadLine();
                b.Add(Cab.CreateCab(s));
            }
            Console.WriteLine("Enter a search type:");
            Console.WriteLine("1.By Vehicle Type");
            Console.WriteLine("2.By Capacity");
            int opt = int.Parse(Console.ReadLine());
            switch(opt)
            {
                case 1:
                    Console.WriteLine("Enter the vehicle type:");
                    string str = Console.ReadLine();
                    List<Cab> vtypeList = new CabBO().FindCab(b, str);
                    Console.WriteLine();
                    if (vtypeList.Count == 0)
                    {
                        Console.WriteLine("No such cab is present");
                    }
                    else
                    {
                        Console.WriteLine("{0,-12}{1,-20}{2,-12}{3,-8}{4:0.0}\n", "Driver Name", "Registration Number", "Vehicle Type", "Capacity", "Cost Per Km");
                        foreach (Cab c in vtypeList)
                        {
                            Console.WriteLine("{0,-12}{1,-20}{2,-12}{3,-8}{4:0.0}\n", c.DriverName, c.RegistrationNumber, c.VehicleType, c.Capacity, c.CostPerKm);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the capacity:");
                    string str1 = Console.ReadLine();
                    List<Cab> capacityList = new CabBO().FindCab(b, str1);
                    Console.WriteLine();
                    if (capacityList.Count == 0)
                    {
                        Console.WriteLine("No such cab is present");
                    }
                    else
                    {
                        Console.WriteLine("{0,-12}{1,-20}{2,-12}{3,-8}{4:0.0}\n", "Driver Name", "Registration Number", "Vehicle Type", "Capacity", "Cost Per Km");
                        foreach (Cab c in capacityList)
                        {
                            Console.WriteLine("{0,-12}{1,-20}{2,-12}{3,-8}{4:0.0}\n", c.DriverName, c.RegistrationNumber, c.VehicleType, c.Capacity, c.CostPerKm);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}
