using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          //  User<string> u1 = new User<string>();
            User<Customer2> u2 = new User<Customer2>();
            User<Test> u3 = new User<Test>();
            Customer c = new Customer();
            Console.WriteLine(u3.GetType());
        }
        public class User<T1> where T1 : IEnumerable
        {
            T1 i;
        }
        public class Customer : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        public class Customer2:Customer
        {

        }
        public class Customer3: Customer2
        {

        }
        class Test : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        class Window
        {

        }
    }
}
