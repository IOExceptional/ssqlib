using SSQLib;
using System.Net;
using Xunit;

namespace Test.SSQLib
{
    public class PlayerTests
    {
        [Fact]
        public void TestFakePlayerServerThrowsExceptionWithIpEndpoint()
        {
            Assert.Throws(typeof(SSQLServerException), () =>
                {
                    SSQL query = new SSQL();
                    //127.0.0.2 set to stop loopback potentially resolving and failing test
                    query.Players(new IPEndPoint(IPAddress.Parse("127.0.0.2"), 27015));
                });
        }

        [Fact]
        public void TestFakePlayerServerThrowsExceptionWithStringIp()
        {
            Assert.Throws(typeof(SSQLServerException), () =>
            {
                SSQL query = new SSQL();
                //127.0.0.2 set to stop loopback potentially resolving and failing test
                query.Players("127.0.0.2", 27015);
            });
        }
    }
}
