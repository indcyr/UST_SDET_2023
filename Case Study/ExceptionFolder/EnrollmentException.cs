using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study.ExceptionFolder
{
    internal class EnrollementException : Exception
    {
        public EnrollementException(string message) : base(message)
        {
        }
    }

}
