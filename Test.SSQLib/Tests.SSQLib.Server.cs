using SSQLib;
using System.Net;
using Xunit;

namespace Test.SSQLib
{
    public class Tests
    {
        [Fact]
        public void TestFakeServerThrowsException()
        {
            Assert.Throws(typeof(SSQLServerException), () =>
                {
                    SSQL query = new SSQL();
                    query.Server(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 27015));
                });
        }
    }
}
