using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_7_Req_2
{
    class Customer
    {
        long _id;
        string _name;
        string _mobileNumber;
        DateTime _birthdate;
        double _averageSpeedAmount;
        double _totalAmount;
        DateTime _dateEnrolled;
        double _rating;

        public long Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string MobileNumber { get => _mobileNumber; set => _mobileNumber = value; }
        public DateTime Birthdate { get => _birthdate; set => _birthdate = value; }
        public double AverageSpeedAmount { get => _averageSpeedAmount; set => _averageSpeedAmount = value; }
        public double TotalAmount { get => _totalAmount; set => _totalAmount = value; }
        public DateTime DateEnrolled { get => _dateEnrolled; set => _dateEnrolled = value; }
        public double Rating { get => _rating; set => _rating = value; }
    }
}
