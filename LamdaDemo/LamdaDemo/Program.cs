using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaDemo
{
    class Program
    {
        //public delegate void PrintDelegate();
        //public delegate void PrintWithDelegate(string str);
        //public void Print()
        //{
        //    Console.WriteLine("Msg from print function");
        //}
        //public void PrintParameters(string s)
        //{
        //    Console.WriteLine("Msg from printParameter function" + s);
        //}
        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    PrintDelegate d1 = new PrintDelegate(p.Print);
        //    PrintWithDelegate d2 = new PrintWithDelegate(p.PrintParameters);
        //    d1();
        //    d2("abc");
        //    Console.ReadLine();
        //}

        //public delegate void PrintDelegate();
        //public delegate void DisplayDelegate(string str, int x);
        //static void Main(string[] args)
        //{
        //    PrintDelegate d1 = delegate ()
        //    {
        //        Console.WriteLine("Msg from anonymous function");
        //    };

        //    DisplayDelegate d2 = delegate (string n1, int n2)
        //      {
        //          Console.WriteLine(n1);
        //          Console.WriteLine(n2);
        //      };
        //    d1();
        //    d2("Parag", 10);
        //    Console.ReadLine();

        //public delegate int SquareDelegates(int n);
        //static void Main(string[] args)
        //{
        //    SquareDelegates d1 = (x => x * x * x);
        //    int res = d1(6);
        //    Console.WriteLine("Sqaure of given number is:" + res);

        //}
        //public delegate int AddDelegates(int n1, int n2);
        //static void Main(string[] args)
        //{
        //    AddDelegates d1 = ((x, y) => x + y);
        //    int res = d1(6, 4);
        //    Console.WriteLine("Addition of given number is:" + res);

        //}
        //public delegate int AddDelegates(int n1, int n2);
        //static void Main(string[] args)
        //{
        //    AddDelegates d1 = ((x, y) => x + y);
        //    AddDelegates d2 = delegate (int n1, int n2)
        //      {
        //          return n1 + n2;
        //      };
        //    int res1 = d1(6, 4);
        //    int res2 = d2(10, 10);
        //    Console.WriteLine("Addition of given number is:" + res1);
        //    Console.WriteLine("Addition of given number is:" + res2);
        //}

        //public delegate int AddDelegate(int x, int y);
        //public delegate int SubDelegate(int x, int y);
        //public delegate int MulDelegate(int x, int y);
        //public delegate int DivDelegate(int x, int y);
        //static void Main(string[] args)
        //{
        //    AddDelegate d1 = delegate (int n1, int n2)
        //      {
        //          return n1 + n2;
        //      };
        //    SubDelegate d2 = delegate (int n1, int n2)
        //    {
        //        return n1 - n2;
        //    };
        //    MulDelegate d3 = delegate (int n1, int n2)
        //    {
        //        return n1 * n2;
        //    };
        //    DivDelegate d4 = delegate (int n1, int n2)
        //    {
        //        return n1 / n2;
        //    };
        //    int res1 = d1(10, 20);
        //    int res2 = d2(10, 20);
        //    int res3 = d3(10, 20);
        //    int res4 = d4(10, 20);

        //    Console.WriteLine("Addition of Two number:" + res1);
        //    Console.WriteLine("Substraction of Two number:" + res2);
        //    Console.WriteLine("Multiplication of Two number:" + res3);
        //    Console.WriteLine("Division of Two number:" + res4);

        //public delegate int PrintDelegate(int x, int y);
        //static void Main(string[] args)
        //{
        //    PrintDelegate d1 = delegate (int n1, int n2)
        //      {
        //          return n1 + n2;
        //      };
        //    PrintDelegate d2 = delegate (int n1, int n2)
        //    {
        //        return n1 - n2;
        //    };
        //    PrintDelegate d3 = delegate (int n1, int n2)
        //    {
        //        return n1 * n2;
        //    };
        //    PrintDelegate d4 = delegate (int n1, int n2)
        //    {
        //        return n1 / n2;
        //    };
        //    int res1 = d1(10, 20);
        //    int res2 = d2(10, 20);
        //    int res3 = d3(10, 20);
        //    int res4 = d4(10, 20);

        //    Console.WriteLine(res1 + "\t" + res2 + "\t" + res3 + "\t" + res4);

       

    }
}
