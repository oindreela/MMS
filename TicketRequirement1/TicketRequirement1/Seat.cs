using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketRequirement1
{
    class Seat
    {
        private int seatNo;
        private string type;
        private double price;
        private string passengerName;
        private string gender;

        public int SeatNo
        {
            get { return seatNo; }
            set { seatNo = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string PassengerName
        {
            get { return passengerName; }
            set { passengerName = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Seat() { }
        public Seat(int seat_no,string typ,double prize,string pasngrname,string gendr)
        {
            SeatNo = seat_no;
            Type = typ;
            Price = prize;
            PassengerName = pasngrname;
            Gender = gendr;
        }

        public override string ToString()
        {
            return string.Format("Seat No:{0}\nType:{1}\nPrice:{2}\nPassenger Name:{3}\nGender:{4}",SeatNo,Type,Price,PassengerName,Gender);
        }

        public override bool Equals(Object obj)
        {
            Seat o = (Seat)obj;
            if (this.SeatNo == o.SeatNo && this.Type.ToLower().Equals(o.Type.ToLower()))
                return true;
            else
                return false;
        }
        
    }
}
