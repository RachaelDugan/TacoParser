using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LoggingKata
{
    internal class DataConversion
    {
        public static double ConvertToMiles(double meters)
        {
            return (meters / 1609.344);
        }
    }
}
