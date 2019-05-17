using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CabRequirement3
{
    class Customer
    {
        public static bool ValidRegistrationNumber(string regNumber)
        {
            string pattern = @"[A-Z]{2}\s[0-9]{1,2}|(\s[A-Z]{0,2}?)\s[0-9]{1,4}";
            bool s = Regex.IsMatch(regNumber, pattern);
            if(s==true)
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
