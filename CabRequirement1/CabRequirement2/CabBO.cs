using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRequirement2
{
    class CabBO
    {
        public List<Cab> FindCab(List<Cab> cabList, string vehicleType)
        {
            var newlist = from c in cabList
                          where c.VehicleType == vehicleType
                          select c;
          
            return newlist.ToList();
        }

        public List<Cab> FindCab(List<Cab> cabList, int capacity)
        {
            var newlist = from c in cabList
                          where c.Capacity ==capacity
                          select c;
           
            return newlist.ToList();
        }
    }
}
