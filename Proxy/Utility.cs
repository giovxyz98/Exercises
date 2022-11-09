using System;

namespace ProxyEs
{
    internal partial class Proxy
    {
        public static class Utility
        {
            public static Random random = new Random();
            public static int minRangeIP=0;
            public static int maxRangeIP=255;
            public static int numbOfConnection=1;
            public static string GeneraIp(int minRangeIP, int maxRangeIP)
            {
                string Ip = ($"{random.Next(minRangeIP, maxRangeIP)}.{random.Next(minRangeIP, maxRangeIP)}.{random.Next(minRangeIP, maxRangeIP)}.{random.Next(minRangeIP, maxRangeIP)}");
                return Ip;
            }
            public static string addIp()
            {
                string _ip;
                _ip = Utility.GeneraIp(0, 255);

                return _ip;



            }
        }
    }
}




