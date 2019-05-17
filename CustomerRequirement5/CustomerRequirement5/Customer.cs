using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRequirement5
{
    class Customer
    {
        long _id;
        string _name;
        char _gender;
        string _email;
        string _contactNumber;
        DateTime _createdOn;

        public Customer() { }
        public Customer(long id, string name, char gender, string email, string contactNumber, DateTime createdOn)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _email = email;
            _contactNumber = contactNumber;
            _createdOn = createdOn;
        }

        public long Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public string Email { get => _email; set => _email = value; }
        public string ContactNumber { get => _contactNumber; set => _contactNumber = value; }
        public DateTime CreatedOn { get => _createdOn; set => _createdOn = value; }

        public static List<Customer> PopulateCustomers(List<string> csvList)
        {
            List<Customer> a =new List<Customer>();
            foreach(string s in csvList)
            {
                string[] s1 = s.Split(',');
                a.Add(new Customer(long.Parse(s1[0]), s1[1], char.Parse(s1[2]), s1[3], s1[4], DateTime.Parse(s1[5])));
            }
            return a;
        }

        public static List<Customer> FindCustomerNameFromList(List<Customer> customers,string subString)
        {
            List<Customer> b = new List<Customer>();
            foreach(Customer x in customers)
            {
                if (x.Name.Contains(subString)){
                    b.Add(x);
                }
            }
            return b;
        }
    }
}
