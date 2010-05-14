using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSQLib
{
    class SSQLServerException : System.Exception
    {
        public SSQLServerException(string message) : base(message)
        {

        }
    }
}
