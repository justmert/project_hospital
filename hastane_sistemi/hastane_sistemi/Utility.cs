using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane_sistemi
{
    class Utility
    {
        public static String ConnectionStr = null;
        public static String first_upper(String str)
        {
            string uppered = char.ToUpper(str.First()) + str.Substring(1).ToLower();
            return uppered;
        }
    }
}
