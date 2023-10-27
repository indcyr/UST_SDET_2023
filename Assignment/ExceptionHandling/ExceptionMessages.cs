using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ExceptionHandling
{
    internal class ExceptionMessages
    {
       public static Dictionary<int, string> messages = new Dictionary<int, string>()
        {
            {1,"Patient Name or Diagnosis cannot be null"},
            {2,"Total cost cannot be a negative value" }
        };
    }
        internal class InvalidPatientDataException : Exception
        {
            public InvalidPatientDataException(string message) : base(message)
            {

            }
        }
            internal class InvalidMedicalRecordException : Exception
            {
                public InvalidMedicalRecordException(string message) : base(message)
                {

                }

            }

        }

    

