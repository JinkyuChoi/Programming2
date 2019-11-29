using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8
{
    // Question6
    public class ThrowException : Exception
    {
        public ThrowException(string message)
             : base(message)
        {
            ;
        }

        public ThrowException(string message, Exception innerException)
            : base(message, innerException)
        {
            ;
        }
    }
}
