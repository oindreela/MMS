using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRequirement1
{
    class Customer
    {
        private string _name;
        private string _gender;
        private string _contactNumber;
        private string _email;

        public Customer() { }
        public Customer(string name, string gender, string contactNumber, string email)
        {
            _name = name;
            _gender = gender;
            _contactNumber = contactNumber;
            _email = email;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string ContactNumber { get { return _contactNumber; } set { _contactNumber = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public override string ToString()
        {
            return string.Format("Name:{0}\nGender:{1}\nContact Number:{2}\nEmail:{3}", Name, Gender, ContactNumber, Email);
        }

        public override bool Equals(object obj)
        {
            Customer c1 = (Customer)obj;
            if (this.Name.ToLower().Equals(c1.Name.ToLower()) & this.ContactNumber.ToLower().Equals(c1.ContactNumber.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

