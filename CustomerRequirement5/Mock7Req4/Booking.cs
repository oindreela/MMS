using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock7Req4
{
    class Booking
    {
        long _id;
        string _customerName;
        Table _table;
        int _memberPresent;
        double _billamount;
        DateTime _bookingTime;

        public Booking() { }

        public Booking(long id, string customerName, Table table, int memberPresent, double billamount, DateTime bookingTime)
        {
            _id = id;
            _customerName = customerName;
            _table = table;
            _memberPresent = memberPresent;
            _billamount = billamount;
            _bookingTime = bookingTime;
        }

        public long Id { get => _id; set => _id = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public int MemberPresent { get => _memberPresent; set => _memberPresent = value; }
        public double Billamount { get => _billamount; set => _billamount = value; }
        public DateTime BookingTime { get => _bookingTime; set => _bookingTime = value; }
        internal Table Table { get => _table; set => _table = value; }
    }
}
