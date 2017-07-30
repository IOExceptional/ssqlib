using System;
using System.Net;

namespace SSQLib
{
    public class EndPointHelpers
    {
        public static IPEndPoint GetIPEndPointFromHostName(string hostName, int port, bool throwIfMoreThanOneIP)
        {
            var addresses = Dns.GetHostAddresses(hostName);
            if (addresses.Length == 0)
            {
                throw new ArgumentException(
                    "Unable to retrieve address from specified host name.",
                    "hostName"
                );
            }
            else if (throwIfMoreThanOneIP && addresses.Length > 1)
            {
                throw new ArgumentException(
                    "There is more that one IP address to the specified host.",
                    "hostName"
                );
            }
            return new IPEndPoint(addresses[0], port); // Port gets validated here.
        }
    }
}
