using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRequirement2
{
    class Cab
    {
        private string _driverName;
        private string _registrationNumber;
        private string _vehicleType;
        private int _capacity;
        private double _costPerKm;

        public Cab() { }
        public Cab(string driverName, string registrationNumber, string vehicleType, int capacity, double costPerKm)
        {
            _driverName = driverName;
            _registrationNumber = registrationNumber;
            _vehicleType = vehicleType;
            _capacity = capacity;
            _costPerKm = costPerKm;
        }

        public string DriverName { get { return _driverName; } set { _driverName = value; } }
        public string RegistrationNumber { get { return _registrationNumber; } set { _registrationNumber = value; } }
        public string VehicleType { get { return _vehicleType; } set { _vehicleType = value; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; } }
        public double CostPerKm { get { return _costPerKm; } set { _costPerKm = value; } }

        public static Cab CreateCab(string details)
        {
            string[] str = details.Split(',');
            Cab c1 = new Cab(str[0],str[1],str[2],int.Parse(str[3]),double.Parse(str[4]));
            return c1;
        }

    }
}
